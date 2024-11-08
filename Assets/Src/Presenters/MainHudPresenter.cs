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
		[SerializeField] private TextMeshProUGUI _goal1Text;
		[SerializeField] private TextMeshProUGUI _goal2Text;
		[SerializeField] private TextMeshProUGUI _ammotText;
		[SerializeField] private Button _gameOverButton;

		private IGameDataProviderLocator _dataProvider;
		private IGameServices _services;
		private IGameControllerLocator _gameController;

		private void Awake()
		{
			_dataProvider = MainInstaller.Resolve<IGameDataProviderLocator>();
			_services = MainInstaller.Resolve<IGameServices>();
			_gameController = MainInstaller.Resolve<IGameControllerLocator>();

			_timer.Init(_services);
			_gameOverButton.onClick.AddListener(GameOverClicked);
		}

		protected override void OnOpened()
		{
			_gameController.GameplayController.Ammo.InvokeObserve(OnAmmoUpdated);
			_gameController.GameplayController.Goals.Observe(OnGoalsUpdated);

			_goal1Text.text = _gameController.GameplayController.Goals[0].Value.ToString();
			_goal2Text.text = _gameController.GameplayController.Goals[1].Value.ToString();
		}

		private void OnAmmoUpdated(int oldValue, int newValue)
		{
			_ammotText.text = $"Ammo: {newValue.ToString()}";
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

		private void GameOverClicked()
		{
			_services.MessageBrokerService.Publish(new OnGameOverMessage());
		}
	}
}