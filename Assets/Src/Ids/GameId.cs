using System.Collections.Generic;
using System.Collections.ObjectModel;

/* AUTO GENERATED CODE */
namespace Game.Ids
{
	public enum GameId
	{
		Random,
		SoftCurrency,
		HardCurrency,
		Baby,
		ToySpaceship,
		ToyBrick,
		Toilet,
		Poop,
		TreeApple,
		Hills,
		Cloud,
		Dog,
		Cat,
		Moon,
		Mushroom,
		Cemetery,
		Foot,
		UFO,
		Banana,
		Orange,
		Egg,
		Carrot,
		CottonCandy,
		Sword,
		Axe,
		Hammer,
		Cannon,
		CannonBall,
		House,
		Building,
		Tire,
		Flag,
		Deodorant
	}

	public enum GameIdGroup
	{
		GameDesign,
		Currency,
		Piece
	}

	public static class GameIdLookup
	{
		public static bool IsInGroup(this GameId id, GameIdGroup group)
		{
			if (!_groups.TryGetValue(id, out var groups))
			{
				return false;
			}
			return groups.Contains(group);
		}

		public static IList<GameId> GetIds(this GameIdGroup group)
		{
			return _ids[group];
		}

		public static IList<GameIdGroup> GetGroups(this GameId id)
		{
			return _groups[id];
		}

		public class GameIdComparer : IEqualityComparer<GameId>
		{
			public bool Equals(GameId x, GameId y)
			{
				return x == y;
			}

			public int GetHashCode(GameId obj)
			{
				return (int)obj;
			}
		}

		public class GameIdGroupComparer : IEqualityComparer<GameIdGroup>
		{
			public bool Equals(GameIdGroup x, GameIdGroup y)
			{
				return x == y;
			}

			public int GetHashCode(GameIdGroup obj)
			{
				return (int)obj;
			}
		}

		private static readonly Dictionary<GameId, ReadOnlyCollection<GameIdGroup>> _groups =
			new Dictionary<GameId, ReadOnlyCollection<GameIdGroup>> (new GameIdComparer())
			{
				{
					GameId.Random, new List<GameIdGroup>
					{
						GameIdGroup.GameDesign
					}.AsReadOnly()
				},
				{
					GameId.SoftCurrency, new List<GameIdGroup>
					{
						GameIdGroup.Currency
					}.AsReadOnly()
				},
				{
					GameId.HardCurrency, new List<GameIdGroup>
					{
						GameIdGroup.Currency
					}.AsReadOnly()
				},
				{
					GameId.Baby, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.ToySpaceship, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.ToyBrick, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Toilet, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Poop, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.TreeApple, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Hills, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Cloud, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Dog, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Cat, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Moon, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Mushroom, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Cemetery, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Foot, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.UFO, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Banana, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Orange, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Egg, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Carrot, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.CottonCandy, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Sword, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Axe, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Hammer, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Cannon, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.CannonBall, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.House, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Building, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Tire, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Flag, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
				{
					GameId.Deodorant, new List<GameIdGroup>
					{
						GameIdGroup.Piece
					}.AsReadOnly()
				},
			};

		private static readonly Dictionary<GameIdGroup, ReadOnlyCollection<GameId>> _ids =
			new Dictionary<GameIdGroup, ReadOnlyCollection<GameId>> (new GameIdGroupComparer())
			{
				{
					GameIdGroup.GameDesign, new List<GameId>
					{
						GameId.Random
					}.AsReadOnly()
				},
				{
					GameIdGroup.Currency, new List<GameId>
					{
						GameId.SoftCurrency,
						GameId.HardCurrency
					}.AsReadOnly()
				},
				{
					GameIdGroup.Piece, new List<GameId>
					{
						GameId.Baby,
						GameId.ToySpaceship,
						GameId.ToyBrick,
						GameId.Toilet,
						GameId.Poop,
						GameId.TreeApple,
						GameId.Hills,
						GameId.Cloud,
						GameId.Dog,
						GameId.Cat,
						GameId.Moon,
						GameId.Mushroom,
						GameId.Cemetery,
						GameId.Foot,
						GameId.UFO,
						GameId.Banana,
						GameId.Orange,
						GameId.Egg,
						GameId.Carrot,
						GameId.CottonCandy,
						GameId.Sword,
						GameId.Axe,
						GameId.Hammer,
						GameId.Cannon,
						GameId.CannonBall,
						GameId.House,
						GameId.Building,
						GameId.Tire,
						GameId.Flag,
						GameId.Deodorant
					}.AsReadOnly()
				},
			};
	}
}
