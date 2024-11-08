using Game.Ids;
using Game.Messages;
using Game.Services;
using GameLovers.Services;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game.ViewControllers
{
	[RequireComponent(typeof(Rigidbody))]
	public class PieceViewController : MonoBehaviour, IPointerUpHandler,  IPointerDownHandler
	{
		[SerializeField] private Rigidbody _rigidbody;

		private GameId _gameId;
		private IGameServices _gameServices;
		private Action<PieceViewController> _despawn;

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
			}
		}

		private void FixedUpdate()
		{
			if (_rigidbody.linearVelocity.y < 0 && _rigidbody.position.z < 10)
			{
				_rigidbody.position += new Vector3(0, 0, 20f);
			}
		}

		public void Setup(GameId id, Action<PieceViewController> despawn)
		{
			_gameId = id;
			_despawn = despawn;
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

		public void Spawn()
		{
			var direction = new Vector3(
				Freya.Random.Range(-0.4f, 0.4f),
				Freya.Random.Range(0.5f, 0.7f),
				Freya.Random.Range(-0.01f, 0.01f));

			transform.rotation = Freya.Random.Rotation;
			transform.position = new Vector3(Freya.Random.Range(-5f, 5f), -11f, 5f);

			_rigidbody.linearVelocity = Vector3.zero;
			_rigidbody.angularVelocity = Vector3.zero;

			gameObject.SetActive(true);
			_rigidbody.AddForce(direction * 30f, ForceMode.Impulse);
			_rigidbody.AddTorque(Freya.Random.Direction3D * 3f, ForceMode.Impulse);
		}

		public void Despawn()
		{
			_despawn(this);
			gameObject.SetActive(false);
		}
	}
}
