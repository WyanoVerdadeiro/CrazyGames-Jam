using GameLovers.Services;
using UnityEngine;

namespace Game.MonoComponent
{
	public class PieceSpawnerMonoComponent : MonoBehaviour
	{
		[SerializeField] private PieceMonoComponent _piecePrefab;

		private IObjectPool<PieceMonoComponent> _objectPool;
		private float _nextTick;

		private void Awake()
		{
			_objectPool = new GameObjectPool<PieceMonoComponent>(10, _piecePrefab);
		}

		private void Update()
		{
			if (Time.time < _nextTick) return;

			_nextTick = Time.time + Freya.Random.Value;

			_objectPool.Spawn();
		}
	}
}
