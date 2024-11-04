using System;
using System.Threading.Tasks;
using GameLovers.Services;
using GameLovers.StatechartMachine;
using Game.Ids;
using Game.Services;
using UnityEngine;
using Game.Presenters;
using Game.Messages;
using Game.Commands;
using Game.Logic;
using Game.Controllers;

namespace Game.StateMachines
{
	/// <summary>
	/// This object contains the behaviour logic for the Gameplay State in the <seealso cref="GameStateMachine"/>
	/// </summary>
	public class GameplayState
	{
		public static readonly IStatechartEvent GAME_OVER_EVENT = new StatechartEvent("Game Over Event");

		private static readonly IStatechartEvent RESTART_CLICKED_EVENT = new StatechartEvent("Restart Button Clicked Event");

		private readonly IGameUiService _uiService;
		private readonly IGameServices _services;
		private readonly IGameDataProvider _gameDataProvider;
		private readonly Action<IStatechartEvent> _statechartTrigger;

		private GameControllerLocator _gameControllerLocator;

		public GameplayState(IInstaller installer, Action<IStatechartEvent> statechartTrigger)
		{
			_gameDataProvider = installer.Resolve<IGameDataProvider>();
			_services = installer.Resolve<IGameServices>();
			_uiService = installer.Resolve<IGameUiServiceInit>();
			_statechartTrigger = statechartTrigger;
		}

		/// <summary>
		/// Setups the Adventure gameplay state
		/// </summary>
		public void Setup(IStateFactory stateFactory)
		{
			var initial = stateFactory.Initial("Initial");
			var final = stateFactory.Final("Final");
			var gameplayLoading = stateFactory.TaskWait("Gameplay Loading");
			var gameStateCheck = stateFactory.Choice("GameOver Check");
			var gameplay = stateFactory.State("Gameplay");
			var gameOver = stateFactory.State("GameOver");

			initial.Transition().Target(gameplayLoading);
			initial.OnExit(SubscribeEvents);
			
			gameplayLoading.WaitingFor(LoadGameplayAssets).Target(gameplay);
			gameplayLoading.OnExit(GameReady);

			gameStateCheck.OnEnter(GameInit);
			gameStateCheck.Transition().Condition(IsGameOver).Target(gameOver);
			gameStateCheck.Transition().Target(gameplay);

			gameplay.OnEnter(OpenGameplayUi);
			gameplay.Event(GAME_OVER_EVENT).Target(gameOver);
			gameplay.OnExit(CloseGameplayUi);

			gameOver.OnEnter(GameOver);
			gameOver.OnEnter(OpenGameOverUi);
			gameOver.Event(RESTART_CLICKED_EVENT).OnTransition(RestartGame).Target(gameStateCheck);
			gameOver.OnExit(CloseGameOverUi);

			final.OnEnter(UnsubscribeEvents);
		}

		private void SubscribeEvents()
		{
			_gameControllerLocator = new GameControllerLocator(_services);

			_services.MessageBrokerService.Subscribe<OnGameOverMessage>(OnGameOverMessage);
			_services.MessageBrokerService.Subscribe<OnGameRestartClickedMessage>(OnGameRestartClickedMessage);
		}

		private void UnsubscribeEvents()
		{
			_gameControllerLocator = null;

			_services.MessageBrokerService.UnsubscribeAll(this);
		}

		private void OnGameOverMessage(OnGameOverMessage message)
		{
			_statechartTrigger(GAME_OVER_EVENT);
		}

		private void OnGameRestartClickedMessage(OnGameRestartClickedMessage message)
		{
			_statechartTrigger(RESTART_CLICKED_EVENT);
		}

		private void GameInit()
		{
			_services.MessageBrokerService.Publish(new OnGameInitMessage());
		}

		private void RestartGame()
		{
			_services.CommandService.ExecuteCommand(new RestartGameCommand());
		}

		private bool IsGameOver()
		{
			return false;
		}

		private void OpenGameplayUi()
		{
			_ = _uiService.OpenUiAsync<MainHudPresenter>();
		}

		private void CloseGameplayUi()
		{
			_uiService.CloseUi<MainHudPresenter>();
		}

		private void OpenGameOverUi()
		{
			_ = _uiService.OpenUiAsync<GameOverScreenPresenter>();
		}

		private void CloseGameOverUi()
		{
			_uiService.CloseUi<GameOverScreenPresenter>();
		}

		private void GameReady()
		{
			_gameControllerLocator.Enable();
		}

		private void GameOver()
		{
			_gameControllerLocator.Disable();
		}

		private async Task LoadGameplayAssets()
		{
			await _uiService.LoadGameUiSet(UiSetId.GameplayUi, 0.8f);
			
			GC.Collect();
			await Resources.UnloadUnusedAssets();
		}
	}
}