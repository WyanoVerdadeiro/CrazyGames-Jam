using Game.Ids;
using GameLovers.Services;

namespace Game.Messages
{
	public struct OnGameInitMessage : IMessage { }
	public struct OnGameOverMessage : IMessage { }
	public struct OnGameCompleteMessage : IMessage { }
	public struct OnPieceHitMessage : IMessage 	{ public GameId Piece; }
	public struct OnShootMessage : IMessage { }
	public struct OnGameRestartClickedMessage : IMessage { }
	public struct OnMenuClickedMessage : IMessage { }
	public struct OnPlayClickedMessage : IMessage { }
}
