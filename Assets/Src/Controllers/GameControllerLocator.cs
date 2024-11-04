using Game.Services;
using GameLovers.Services;
using System.Collections.Generic;

namespace Game.Controllers
{
	public interface IGameControllerLocator
	{
		public IGameplayController GameplayController { get; }
	}

	public class GameControllerLocator : IGameControllerLocator, IGameController
	{
		private readonly List<IGameController> _controllers = new List<IGameController>();

		public IGameplayController GameplayController { get; }

		public GameControllerLocator(IGameServices services)
		{
			var gameplayController = new GameplayController(services);

			GameplayController = gameplayController;

			_controllers.Add(gameplayController);
		}

		public void Enable()
		{
			MainInstaller.Bind<IGameControllerLocator>(this);

			foreach (var controller in _controllers)
			{
				controller.Enable();
			}
		}

		public void Disable()
		{
			MainInstaller.Clean<IGameControllerLocator>();

			foreach (var controller in _controllers)
			{
				controller.Disable();
			}
		}
	}
}
