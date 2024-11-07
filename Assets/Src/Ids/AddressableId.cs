/* AUTO GENERATED CODE */

using System.Collections.Generic;
using System.Collections.ObjectModel;
using GameLovers.AssetsImporter;

// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace

namespace Game.Ids
{
	public enum AddressableId
	{
		Prefabs_Configs_DataConfigs,
		Prefabs_Configs_GameConfigs,
		Prefabs_Configs_PieceAssetConfigs,
		Prefabs_Configs_UiConfigs,
		Prefabs_Pieces_Axe,
		Prefabs_Pieces_Baby,
		Prefabs_Pieces_Banana,
		Prefabs_Pieces_Building,
		Prefabs_Pieces_Cannon,
		Prefabs_Pieces_CannonBall,
		Prefabs_Pieces_Carrot,
		Prefabs_Pieces_Cat,
		Prefabs_Pieces_Cemetery,
		Prefabs_Pieces_Cloud,
		Prefabs_Pieces_CottonCandy,
		Prefabs_Pieces_Deodorant,
		Prefabs_Pieces_Dog,
		Prefabs_Pieces_Egg,
		Prefabs_Pieces_Flag,
		Prefabs_Pieces_Foot,
		Prefabs_Pieces_Hammer,
		Prefabs_Pieces_Hills,
		Prefabs_Pieces_House,
		Prefabs_Pieces_Moon,
		Prefabs_Pieces_Mushroom,
		Prefabs_Pieces_Orange,
		Prefabs_Pieces_Poop,
		Prefabs_Pieces_Sword,
		Prefabs_Pieces_Tire,
		Prefabs_Pieces_Toilet,
		Prefabs_Pieces_ToyBrick,
		Prefabs_Pieces_ToySpaceship,
		Prefabs_Pieces_TreeApple,
		Prefabs_Pieces_UFO,
		Prefabs_UI_GameOver,
		Prefabs_UI_Loading_Screen,
		Prefabs_UI_MainHud,
		Prefabs_UI_Menu_Screen
	}

	public enum AddressableLabel
	{
		Label_GenerateIds
	}

	public static class AddressablePathLookup
	{
		public static readonly string PrefabsUI = "Prefabs/UI";
		public static readonly string PrefabsPieces = "Prefabs/Pieces";
		public static readonly string PrefabsConfigs = "Prefabs/Configs";
	}

	public static class AddressableConfigLookup
	{
		public static IList<AddressableConfig> Configs => _addressableConfigs;
		public static IList<string> Labels => _addressableLabels;

		public static AddressableConfig GetConfig(this AddressableId addressable)
		{
			return _addressableConfigs[(int) addressable];
		}

		public static IList<AddressableConfig> GetConfigs(this AddressableLabel label)
		{
			return _addressableLabelMap[_addressableLabels[(int) label]];
		}

		public static IList<AddressableConfig> GetConfigs(string label)
		{
			return _addressableLabelMap[label];
		}

		public static string ToLabelString(this AddressableLabel label)
		{
			return _addressableLabels[(int) label];
		}

		private static readonly IList<string> _addressableLabels = new List<string>
		{
			"GenerateIds"
		}.AsReadOnly();

		private static readonly IReadOnlyDictionary<string, IList<AddressableConfig>> _addressableLabelMap = new ReadOnlyDictionary<string, IList<AddressableConfig>>(new Dictionary<string, IList<AddressableConfig>>
		{
			{"GenerateIds", new List<AddressableConfig>
				{
					new AddressableConfig(0, "Prefabs/UI/Menu Screen.prefab", "Assets/Prefabs/UI/Menu Screen.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(1, "Prefabs/UI/MainHud.prefab", "Assets/Prefabs/UI/MainHud.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(2, "Prefabs/UI/Loading Screen.prefab", "Assets/Prefabs/UI/Loading Screen.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(3, "Prefabs/UI/GameOver.prefab", "Assets/Prefabs/UI/GameOver.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(4, "Prefabs/Pieces/UFO.prefab", "Assets/Prefabs/Pieces/UFO.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(5, "Prefabs/Pieces/TreeApple.prefab", "Assets/Prefabs/Pieces/TreeApple.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(6, "Prefabs/Pieces/ToySpaceship.prefab", "Assets/Prefabs/Pieces/ToySpaceship.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(7, "Prefabs/Pieces/ToyBrick.prefab", "Assets/Prefabs/Pieces/ToyBrick.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(8, "Prefabs/Pieces/Toilet.prefab", "Assets/Prefabs/Pieces/Toilet.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(9, "Prefabs/Pieces/Tire.prefab", "Assets/Prefabs/Pieces/Tire.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(10, "Prefabs/Pieces/Sword.prefab", "Assets/Prefabs/Pieces/Sword.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(11, "Prefabs/Pieces/Poop.prefab", "Assets/Prefabs/Pieces/Poop.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(12, "Prefabs/Pieces/Orange.prefab", "Assets/Prefabs/Pieces/Orange.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(13, "Prefabs/Pieces/Mushroom.prefab", "Assets/Prefabs/Pieces/Mushroom.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(14, "Prefabs/Pieces/Moon.prefab", "Assets/Prefabs/Pieces/Moon.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(15, "Prefabs/Pieces/House.prefab", "Assets/Prefabs/Pieces/House.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(16, "Prefabs/Pieces/Hills.prefab", "Assets/Prefabs/Pieces/Hills.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(17, "Prefabs/Pieces/Hammer.prefab", "Assets/Prefabs/Pieces/Hammer.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(18, "Prefabs/Pieces/Foot.prefab", "Assets/Prefabs/Pieces/Foot.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(19, "Prefabs/Pieces/Flag.prefab", "Assets/Prefabs/Pieces/Flag.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(20, "Prefabs/Pieces/Egg.prefab", "Assets/Prefabs/Pieces/Egg.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(21, "Prefabs/Pieces/Dog.prefab", "Assets/Prefabs/Pieces/Dog.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(22, "Prefabs/Pieces/Deodorant.prefab", "Assets/Prefabs/Pieces/Deodorant.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(23, "Prefabs/Pieces/CottonCandy.prefab", "Assets/Prefabs/Pieces/CottonCandy.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(24, "Prefabs/Pieces/Cloud.prefab", "Assets/Prefabs/Pieces/Cloud.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(25, "Prefabs/Pieces/Cemetery.prefab", "Assets/Prefabs/Pieces/Cemetery.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(26, "Prefabs/Pieces/Cat.prefab", "Assets/Prefabs/Pieces/Cat.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(27, "Prefabs/Pieces/Carrot.prefab", "Assets/Prefabs/Pieces/Carrot.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(28, "Prefabs/Pieces/CannonBall.prefab", "Assets/Prefabs/Pieces/CannonBall.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(29, "Prefabs/Pieces/Cannon.prefab", "Assets/Prefabs/Pieces/Cannon.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(30, "Prefabs/Pieces/Building.prefab", "Assets/Prefabs/Pieces/Building.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(31, "Prefabs/Pieces/Banana.prefab", "Assets/Prefabs/Pieces/Banana.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(32, "Prefabs/Pieces/Baby.prefab", "Assets/Prefabs/Pieces/Baby.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(33, "Prefabs/Pieces/Axe.prefab", "Assets/Prefabs/Pieces/Axe.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(34, "Prefabs/Configs/UiConfigs.asset", "Assets/Prefabs/Configs/UiConfigs.asset", typeof(GameLovers.UiService.UiConfigs), new [] {"GenerateIds"}),
					new AddressableConfig(35, "Prefabs/Configs/PieceAssetConfigs.asset", "Assets/Prefabs/Configs/PieceAssetConfigs.asset", typeof(Game.Configs.PieceAssetConfigs), new [] {"GenerateIds"}),
					new AddressableConfig(36, "Prefabs/Configs/GameConfigs.asset", "Assets/Prefabs/Configs/GameConfigs.asset", typeof(Game.Configs.GameConfigs), new [] {"GenerateIds"}),
					new AddressableConfig(37, "Prefabs/Configs/DataConfigs.asset", "Assets/Prefabs/Configs/DataConfigs.asset", typeof(Game.Configs.DataConfigs), new [] {"GenerateIds"}),
				}.AsReadOnly()}
		});

		private static readonly IList<AddressableConfig> _addressableConfigs = new List<AddressableConfig>
		{
			new AddressableConfig(0, "Prefabs/Configs/DataConfigs.asset", "Assets/Prefabs/Configs/DataConfigs.asset", typeof(Game.Configs.DataConfigs), new [] {"GenerateIds"}),
			new AddressableConfig(1, "Prefabs/Configs/GameConfigs.asset", "Assets/Prefabs/Configs/GameConfigs.asset", typeof(Game.Configs.GameConfigs), new [] {"GenerateIds"}),
			new AddressableConfig(2, "Prefabs/Configs/PieceAssetConfigs.asset", "Assets/Prefabs/Configs/PieceAssetConfigs.asset", typeof(Game.Configs.PieceAssetConfigs), new [] {"GenerateIds"}),
			new AddressableConfig(3, "Prefabs/Configs/UiConfigs.asset", "Assets/Prefabs/Configs/UiConfigs.asset", typeof(GameLovers.UiService.UiConfigs), new [] {"GenerateIds"}),
			new AddressableConfig(4, "Prefabs/Pieces/Axe.prefab", "Assets/Prefabs/Pieces/Axe.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(5, "Prefabs/Pieces/Baby.prefab", "Assets/Prefabs/Pieces/Baby.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(6, "Prefabs/Pieces/Banana.prefab", "Assets/Prefabs/Pieces/Banana.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(7, "Prefabs/Pieces/Building.prefab", "Assets/Prefabs/Pieces/Building.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(8, "Prefabs/Pieces/Cannon.prefab", "Assets/Prefabs/Pieces/Cannon.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(9, "Prefabs/Pieces/CannonBall.prefab", "Assets/Prefabs/Pieces/CannonBall.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(10, "Prefabs/Pieces/Carrot.prefab", "Assets/Prefabs/Pieces/Carrot.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(11, "Prefabs/Pieces/Cat.prefab", "Assets/Prefabs/Pieces/Cat.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(12, "Prefabs/Pieces/Cemetery.prefab", "Assets/Prefabs/Pieces/Cemetery.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(13, "Prefabs/Pieces/Cloud.prefab", "Assets/Prefabs/Pieces/Cloud.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(14, "Prefabs/Pieces/CottonCandy.prefab", "Assets/Prefabs/Pieces/CottonCandy.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(15, "Prefabs/Pieces/Deodorant.prefab", "Assets/Prefabs/Pieces/Deodorant.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(16, "Prefabs/Pieces/Dog.prefab", "Assets/Prefabs/Pieces/Dog.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(17, "Prefabs/Pieces/Egg.prefab", "Assets/Prefabs/Pieces/Egg.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(18, "Prefabs/Pieces/Flag.prefab", "Assets/Prefabs/Pieces/Flag.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(19, "Prefabs/Pieces/Foot.prefab", "Assets/Prefabs/Pieces/Foot.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(20, "Prefabs/Pieces/Hammer.prefab", "Assets/Prefabs/Pieces/Hammer.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(21, "Prefabs/Pieces/Hills.prefab", "Assets/Prefabs/Pieces/Hills.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(22, "Prefabs/Pieces/House.prefab", "Assets/Prefabs/Pieces/House.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(23, "Prefabs/Pieces/Moon.prefab", "Assets/Prefabs/Pieces/Moon.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(24, "Prefabs/Pieces/Mushroom.prefab", "Assets/Prefabs/Pieces/Mushroom.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(25, "Prefabs/Pieces/Orange.prefab", "Assets/Prefabs/Pieces/Orange.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(26, "Prefabs/Pieces/Poop.prefab", "Assets/Prefabs/Pieces/Poop.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(27, "Prefabs/Pieces/Sword.prefab", "Assets/Prefabs/Pieces/Sword.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(28, "Prefabs/Pieces/Tire.prefab", "Assets/Prefabs/Pieces/Tire.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(29, "Prefabs/Pieces/Toilet.prefab", "Assets/Prefabs/Pieces/Toilet.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(30, "Prefabs/Pieces/ToyBrick.prefab", "Assets/Prefabs/Pieces/ToyBrick.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(31, "Prefabs/Pieces/ToySpaceship.prefab", "Assets/Prefabs/Pieces/ToySpaceship.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(32, "Prefabs/Pieces/TreeApple.prefab", "Assets/Prefabs/Pieces/TreeApple.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(33, "Prefabs/Pieces/UFO.prefab", "Assets/Prefabs/Pieces/UFO.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(34, "Prefabs/UI/GameOver.prefab", "Assets/Prefabs/UI/GameOver.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(35, "Prefabs/UI/Loading Screen.prefab", "Assets/Prefabs/UI/Loading Screen.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(36, "Prefabs/UI/MainHud.prefab", "Assets/Prefabs/UI/MainHud.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(37, "Prefabs/UI/Menu Screen.prefab", "Assets/Prefabs/UI/Menu Screen.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"})
		}.AsReadOnly();
	}
}
