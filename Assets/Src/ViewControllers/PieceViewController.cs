using Game.Ids;
using Game.Messages;
using Game.Services;
using GameLovers.Services;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game.ViewControllers
{
	[RequireComponent(typeof(Rigidbody))]
	public class PieceViewController : MonoBehaviour, IPointerUpHandler,  IPointerDownHandler,
		IPoolEntityObject<PieceViewController>, IPoolEntitySpawn
	{
		[SerializeField] private Rigidbody _rigidbody;

		private GameId _gameId;
		private IGameServices _gameServices;
		private IObjectPool<PieceViewController> _objectPool;

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
			if (transform.position.y < -12f)
			{
				Despawn();
				return;
			}
		}

		private void FixedUpdate()
		{
			if (_rigidbody.linearVelocity.y < 0 && _rigidbody.position.z > -5)
			{
				_rigidbody.isKinematic = true;
				_rigidbody.position += new Vector3(0, 0, 20f);
				_rigidbody.WakeUp();
			}
		}

		public void Init(IObjectPool<PieceViewController> pool)
		{
			_objectPool = pool;
		}

		public void Setup(GameId id)
		{
			_gameId = id;
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
			_gameServices.MessageBrokerService.Publish(new OnPieceHitMessage { Piece = _gameId });
		}

		public void OnSpawn()
		{
			var direction = new Vector3(
				Freya.Random.Range(-0.4f, 0.4f),
				Freya.Random.Range(0.5f, 0.7f),
				Freya.Random.Range(-0.01f, 0.01f));

			transform.rotation = Freya.Random.Rotation;
			transform.position = new Vector3(Freya.Random.Range(-5f, 5f), -11f, 5f);

			_rigidbody.AddForce(direction * 30f, ForceMode.Impulse);
			_rigidbody.AddTorque(Freya.Random.Direction3D * 3f, ForceMode.Impulse);
		}
	}
}
