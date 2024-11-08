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
		private readonly IList<PieceViewController> _objectPool = new List<PieceViewController>();
		private readonly IList<PieceViewController> _spawnedPool = new List<PieceViewController>();

		private IGameControllerLocator _contollers;
		private IGameServices _services;
		private float _nextTick;

		public PieceSpawnerController(IGameServices services, IGameControllerLocator contollers)
		{
			_contollers = contollers;
			_services = services;
		}

		public void Enable()
		{
			var ids = GameIdGroup.Piece.GetIds();
			
			for (var i = 0; i < 10; i++)
			{
				Instantiator(ids[UnityEngine.Random.Range(0, ids.Count)]);
			}

			foreach (var goal in _contollers.GameplayController.Goals)
			{
				Instantiator(goal.Key);
				Instantiator(goal.Key);
			}

			_services.TickService.SubscribeOnUpdate(OnUpdate);
		}

		public void Disable()
		{
			foreach (var instance in _spawnedPool)
			{
				GameObject.Destroy(instance.gameObject);
			}
			foreach (var instance in _objectPool)
			{
				GameObject.Destroy(instance.gameObject);
			}

			_objectPool.Clear();
			_spawnedPool.Clear();
			_services.AssetResolverService.UnloadAssets<GameId, GameObject>(false);
			_services.TickService.UnsubscribeOnUpdate(OnUpdate);
		}

		private void OnUpdate(float deltaTime)
		{
			if (Time.time < _nextTick) return;

			_nextTick = Time.time + Freya.Random.Range(0.3f, 0.7f);

			var idx = Freya.Random.Range(0, _objectPool.Count);
			var instance = _objectPool[idx];

			instance.Spawn();
			_objectPool.RemoveAt(idx);
			_spawnedPool.Add(instance);
		}

		private void Instantiator(GameId id)
		{
			var instance = _services.AssetResolverService.RequestAsset<GameId, GameObject>(id, false).Result.GetComponent<PieceViewController>();

			instance.Setup(id, Despawn);
			instance.gameObject.SetActive(false);
			_objectPool.Add(instance);
		}

		private void Despawn(PieceViewController instance)
		{
			_spawnedPool.Remove(instance);
			_objectPool.Add(instance);
		}
	}
}
