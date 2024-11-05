using Game.Services;
using GameLovers.Services;
using System.Collections.Generic;

namespace Game.Controllers
{
	public interface IGameControllerLocator
	{
		public IGameplayController GameplayController { get; }
		bool IsEnabled { get; }
	}

	public interface IGameControllerMasterLocator : IGameControllerLocator, IGameController	{ }

	public class GameControllerLocator : IGameControllerMasterLocator
	{
		private readonly List<IGameController> _controllers = new List<IGameController>();

		public IGameplayController GameplayController { get; }
		public bool IsEnabled { get; private set; }

		public GameControllerLocator(IGameServices services)
		{
			var gameplayController = new GameplayController(services);

			GameplayController = gameplayController;

			_controllers.Add(gameplayController);
		}

		public void Enable()
		{
			foreach (var controller in _controllers)
			{
				controller.Enable();
			}
			IsEnabled = true;
		}

		public void Disable()
		{
			IsEnabled = false;
			foreach (var controller in _controllers)
			{
				controller.Disable();
			}
		}
	}
}
