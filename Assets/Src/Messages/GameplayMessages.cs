using GameLovers.Services;

namespace Game.Messages
{
	public struct OnGameInitMessage : IMessage { }
	public struct OnGameOverMessage : IMessage { }
	public struct OnGameRestartClickedMessage : IMessage { }
	public struct OnPieceHitMessage : IMessage { }
	public struct OnShootMessage : IMessage { }
}
