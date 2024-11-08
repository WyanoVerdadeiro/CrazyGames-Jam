using GameLovers;
using GameLovers.Services;
using GameLovers.UiService;
using Game.Ids;
using Game.Logic;
using Game.Services;
using TMPro;
using UnityEngine;
using Game.Views;
using UnityEngine.UI;
using System;
using Game.Messages;
using Game.Controllers;

namespace Game.Presenters
{
	/// <summary>
	/// This Presenter handles the Main HUD UI by:
	/// - Showing the HUD visual status
	/// </summary>
	public class MainHudPresenter : UiPresenter
	{
		[SerializeField] private TimerView _timer;
		[SerializeField] private Image _goal1Sprite;
		[SerializeField] private Image _goal2Sprite;
		[SerializeField] private TextMeshProUGUI _goal1Text;
		[SerializeField] private TextMeshProUGUI _goal2Text;
		[SerializeField] private TextMeshProUGUI _ammotText;

		private IGameDataProviderLocator _dataProvider;
		private IGameServices _services;
		private IGameControllerLocator _gameController;

		private void Awake()
		{
			_dataProvider = MainInstaller.Resolve<IGameDataProviderLocator>();
			_services = MainInstaller.Resolve<IGameServices>();
			_gameController = MainInstaller.Resolve<IGameControllerLocator>();

			_timer.Init(_services);
		}

		protected override void OnOpened()
		{
			var goals = _gameController.GameplayController.Goals;

			_gameController.GameplayController.Ammo.InvokeObserve(OnAmmoUpdated);
			_gameController.GameplayController.Goals.Observe(OnGoalsUpdated);

			_goal1Text.text = goals[0].Value.ToString();
			_goal2Text.text = goals[1].Value.ToString();
			_goal1Sprite.sprite = _services.AssetResolverService.RequestAsset<GameId, Sprite>(goals[0].Key).Result;
			_goal2Sprite.sprite = _services.AssetResolverService.RequestAsset<GameId, Sprite>(goals[1].Key).Result;
		}

		private void OnAmmoUpdated(int oldValue, int newValue)
		{
			_ammotText.text = newValue.ToString();
		}

		private void OnGoalsUpdated(int index, StructPair<GameId, int> oldValue, StructPair<GameId, int> newValue, ObservableUpdateType updateType)
		{
			if (updateType != ObservableUpdateType.Updated) return;

			if(index == 0)
			{
				_goal1Text.text = newValue.Value.ToString();
			}
			else
			{
				_goal2Text.text = newValue.Value.ToString();
			}
		}
	}
}