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
		IObservableListReader<StructPair<GameId, int>> Goals { get; }
	}

	public class GameplayController : IGameplayController, IGameController
	{
		private IGameControllerLocator _contollers;
		private IGameServices _services;
		private IObservableField<int> _ammo;
		private IObservableList<StructPair<GameId, int>> _goals;
		private IObjectPool<PieceViewController> _objectPool;
		private float _nextTick;

		public IObservableFieldReader<int> Ammo => _ammo;

		public IObservableListReader<StructPair<GameId, int>> Goals => _goals;

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
			_goals = new ObservableList<StructPair<GameId, int>>(new List<StructPair<GameId, int>>());

			_goals.Add(new StructPair<GameId, int>(ids[idx], UnityEngine.Random.Range(3, 10)));
			ids.RemoveAt(idx);
			_goals.Add(new StructPair<GameId, int>(ids[UnityEngine.Random.Range(0, ids.Count)], UnityEngine.Random.Range(3, 10)));

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
			var levelComplete = true;

			for(var i  = 0; i < _goals.Count; i++)
			{
				if(_goals[i].Key == message.Piece)
				{
					var pair = _goals[i];

					pair.Value--;
					_goals[i] = pair;
				}

				if(_goals[i].Value > 0)
				{
					levelComplete = false;
				}
			}

			if(levelComplete)
			{
				_ammo.Value--;
				_services.MessageBrokerService.Publish(new OnGameCompleteMessage());
				return;
			}
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
