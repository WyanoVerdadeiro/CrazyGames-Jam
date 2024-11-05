using Game.Messages;
using Game.Services;
using GameLovers.Services;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game.MonoComponent
{
	[RequireComponent(typeof(Rigidbody))]
	public class PieceMonoComponent : MonoBehaviour, IPointerUpHandler,  IPointerDownHandler,
		IPoolEntityObject<PieceMonoComponent>, IPoolEntitySpawn
	{
		[SerializeField] private Rigidbody _rigidbody;

		private IGameServices _gameServices;
		private IObjectPool<PieceMonoComponent> _objectPool;

		private void OnValidate()
		{
			_rigidbody = _rigidbody == null ? GetComponent<Rigidbody>() : _rigidbody;
		}

		private void Awake()
		{
			_gameServices = MainInstaller.Resolve<IGameServices>();
		}

		private void Update()
		{
			if (transform.localPosition.y < -2f)
			{
				Despawn();
			}
		}

		public void Init(IObjectPool<PieceMonoComponent> pool)
		{
			_objectPool = pool;
		}

		public bool Despawn()
		{
			return _objectPool.Despawn(this);
		}

		public void OnPointerDown(PointerEventData eventData)
		{
			// Do nothing, but needed for IPointerUpHandler to work
		}

		public void OnPointerUp(PointerEventData eventData)
		{
			Despawn();
			_gameServices.MessageBrokerService.Publish(new OnShootMessage());
		}

		public void OnSpawn()
		{
			var angleRng = Freya.Random.Angle / 8f;
			var direction = new Vector3(
				Freya.Random.Range(-1f, 1f) * Mathf.Sin(angleRng),
				Mathf.Cos(angleRng),
				Freya.Random.Range(-0.01f, 0.01f) * Mathf.Sin(angleRng));

			transform.rotation = Freya.Random.Rotation;
			transform.localPosition = Vector3.right * Freya.Random.Range(-5f, 5f);

			_rigidbody.AddForce(direction * 30f, ForceMode.Impulse);
		}
	}
}
