using System.Threading.Tasks;
using Game.Configs;
using Game.Data;
using GameLovers.ConfigsProvider;
using GameLovers.Services;
using GameLovers.StatechartMachine;
using GameLovers.UiService;
using Game.Ids;
using Game.Logic;
using Newtonsoft.Json;
using Game.Services;
using UnityEngine;
using Game.Commands;
using NUnit.Framework;
using System.Collections.Generic;
using System;
using System.ComponentModel;

namespace Game.StateMachines
{
	/// <summary>
	/// This class represents the Loading state in the <seealso cref="GameStateMachine"/>
	/// </summary>
	public class InitialLoadingState
	{
		private readonly IGameServices _services;
		private readonly IGameLogicInit _gameLogic;
		private readonly IUiServiceInit _uiService;
		private readonly IConfigsAdder _configsAdder;
		private readonly IDataService _dataService;
		private readonly IAssetAdderService _assetAdderService;

		public InitialLoadingState(IInstaller installer)
		{
			_gameLogic = installer.Resolve<IGameLogicInit>();
			_services = installer.Resolve<IGameServices>();
			_uiService = installer.Resolve<IUiServiceInit>();
			_configsAdder = installer.Resolve<IConfigsAdder>();
			_dataService = installer.Resolve<IDataService>();
			_assetAdderService = installer.Resolve<IAssetAdderService>();
		}

		/// <summary>
		/// Setups the Initial Loading state
		/// </summary>
		public void Setup(IStateFactory stateFactory)
		{
			var initial = stateFactory.Initial("Initial");
			var final = stateFactory.Final("Final");
			var dataLoading = stateFactory.TaskWait("Initial device data loading");
			var uiLoading = stateFactory.TaskWait("Initial Ui loading");
			
			initial.Transition().Target(dataLoading);
			initial.OnExit(SubscribeEvents);
			
			dataLoading.OnEnter(InitPlugins);
			dataLoading.OnEnter(LoadGameData);
			dataLoading.WaitingFor(LoadConfigs).Target(uiLoading);
			dataLoading.OnExit(InitGameLogic);
			
			uiLoading.WaitingFor(LoadInitialUi).Target(final);
			
			final.OnEnter(UnsubscribeEvents);
		}

		private void UnsubscribeEvents()
		{
			_services.MessageBrokerService.UnsubscribeAll(this);
		}

		private void SubscribeEvents()
		{
			// Add any events to subscribe
		}

		private void InitPlugins()
		{
			if (Debug.isDebugBuild)
			{
				//SRDebug.Init();
			}
		}

		private async Task LoadInitialUi()
		{
			await Task.WhenAll(_uiService.LoadUiSetAsync((int) UiSetId.InitialLoadUi));
		}

		private void InitGameLogic()
		{
			LoadGameData();
			_gameLogic.Init(_dataService, _services);
			_services.CommandService.ExecuteCommand(new SetupFirstTimePlayerCommand());
		}

		private async Task LoadConfigs()
		{
			var uiConfigs = _services.AssetResolverService.LoadAssetAsync<UiConfigs>(AddressableId.Addressables_Configs_UiConfigs.GetConfig().Address);

			await Task.WhenAll(uiConfigs,
				// Single configs
				_services.AssetResolverService.LoadAssetAsync<GameConfigs>(
					AddressableId.Addressables_Configs_GameConfigs.GetConfig().Address,
					result => _configsAdder.AddSingletonConfig(result.Config)),

				// Multi configs
				_services.AssetResolverService.LoadAssetAsync<DataConfigs>(
					AddressableId.Addressables_Configs_DataConfigs.GetConfig().Address,
					result => _configsAdder.AddConfigs(data => (int)data.Id, result.Configs)),

				// Asset configs
				_services.AssetResolverService.LoadAssetAsync<PieceAssetConfigs>(
					AddressableId.Addressables_Configs_PieceAssetConfigs.GetConfig().Address,
					result => _assetAdderService.AddConfigs(result)),
				_services.AssetResolverService.LoadAssetAsync<PieceSpriteAssetConfigs>(
					AddressableId.Addressables_Configs_PieceSpriteAssetConfigs.GetConfig().Address,
					result => _assetAdderService.AddConfigs(result)));

			_uiService.Init(uiConfigs.Result);
			_services.AssetResolverService.UnloadAsset(uiConfigs.Result);
		}

		private void LoadGameData()
		{
			var time = _services.TimeService.DateTimeUtcNow;
			var appData = _dataService.LoadData<AppData>();
			var rngData = _dataService.LoadData<RngData>();
			var playerData = _dataService.LoadData<PlayerData>();

			// First time opens the app
			if (appData.SessionCount == 0)
			{
				var seed = (int)(time.Ticks & int.MaxValue);

				appData.FirstLoginTime = time;
				appData.LoginTime = time;
				rngData.Seed = seed;
				rngData.State = RngService.GenerateRngState(seed);
			}

			appData.SessionCount += 1;
			appData.LastLoginTime = appData.LoginTime;
			appData.LoginTime = time;
		}
	}
}