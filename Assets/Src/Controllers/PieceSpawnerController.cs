using Game.Configs;
using Game.Ids;
using Game.Services;
using Game.ViewControllers;
using GameLovers.Services;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Controllers
{
	public interface IPieceSpawnerController { }

	public class PieceSpawnerController : IPieceSpawnerController, IGameController
	{
		private IGameControllerLocator _contollers;
		private IGameServices _services;
		private IObjectPool<PieceViewController> _objectPool;
		private float _nextTick;
		private List<GameId> _pieceIds = new List<GameId>();

		public PieceSpawnerController(IGameServices services, IGameControllerLocator contollers)
		{
			_contollers = contollers;
			_services = services;
		}

		public void Enable()
		{
			var ids = GameIdGroup.Piece.GetIds();

			foreach (var goal in _contollers.GameplayController.Goals)
			{
				_pieceIds.Add(goal.Key);
				_pieceIds.Add(goal.Key);
			}
			
			for (var i = 0; i < 10; i++)
			{
				_pieceIds.Add(ids[UnityEngine.Random.Range(0, ids.Count)]);
			}

			_objectPool = new GameObjectPool<PieceViewController>(15, null, Instantiator);
			_services.TickService.SubscribeOnUpdate(OnUpdate);
		}

		private PieceViewController Instantiator(PieceViewController _)
		{
			var id = _pieceIds[UnityEngine.Random.Range(0, _pieceIds.Count)];
			var instance = _services.AssetResolverService.RequestAsset<GameId, GameObject>(id, false).Result.GetComponent<PieceViewController>();

			instance.Setup(id);
			instance.gameObject.SetActive(false);

			return instance;
		}

		public void Disable()
		{
			var objects = _objectPool.Clear();

			foreach (var obj in objects)
			{
				_services.AssetResolverService.UnloadAsset(obj.gameObject);
			}

			_services.TickService.UnsubscribeOnUpdate(OnUpdate);
		}

		private void OnUpdate(float deltaTime)
		{
			if (Time.time < _nextTick) return;

			_nextTick = Time.time + Freya.Random.Range(0.3f, 0.7f);

			_objectPool.Spawn();
		}
	}
}
