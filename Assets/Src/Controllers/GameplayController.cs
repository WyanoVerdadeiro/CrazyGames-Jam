using Game.Ids;
using Game.Messages;
using Game.Services;
using Game.ViewControllers;
using GameLovers;
using GameLovers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.Controllers
{
	public interface IGameplayController
	{
		IObservableFieldReader<int> Ammo { get; }
		IObservableDictionaryReader<GameId, int> Goals { get; }
	}

	public class GameplayController : IGameplayController, IGameController
	{
		private IGameControllerLocator _contollers;
		private IGameServices _services;
		private IObservableField<int> _ammo;
		private IObservableDictionary<GameId, int> _goals;
		private IObjectPool<PieceViewController> _objectPool;
		private float _nextTick;

		public IObservableFieldReader<int> Ammo => _ammo;

		public IObservableDictionaryReader<GameId, int> Goals => _goals;

		public GameplayController(IGameServices services, IGameControllerLocator contollers)
		{
			_contollers = contollers;
			_services = services;
		}

		public void Enable()
		{
			var ids = new List<GameId>(GameIdGroup.Piece.GetIds());
			var idx = UnityEngine.Random.Range(0, ids.Count);

			_ammo = new ObservableField<int>(50);
			_goals = new ObservableDictionary<GameId, int>(new Dictionary<GameId, int>());

			_goals.Add(ids[idx], UnityEngine.Random.Range(3, 6));
			ids.RemoveAt(idx);
			_goals.Add(ids[UnityEngine.Random.Range(0, ids.Count)], UnityEngine.Random.Range(3, 6));

			_services.MessageBrokerService.Subscribe<OnPieceHitMessage>(OnPieceHitMessage);
			_services.MessageBrokerService.Subscribe<OnShootMessage>(OnShootMessage);
		}

		public void Disable()
		{
			_services.MessageBrokerService.Unsubscribe<OnPieceHitMessage>(OnPieceHitMessage);
			_services.MessageBrokerService.Unsubscribe<OnShootMessage>(OnShootMessage);

			_ammo = null;
		}

		private void OnPieceHitMessage(OnPieceHitMessage message)
		{
			OnShootMessage(new OnShootMessage());
		}

		private void OnShootMessage(OnShootMessage message)
		{
			_ammo.Value--;

			if (_ammo.Value <= 0)
			{
				_services.MessageBrokerService.Publish(new OnGameOverMessage());
			}
		}
	}
}
