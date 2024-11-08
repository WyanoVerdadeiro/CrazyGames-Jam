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
		Addressables_Configs_DOTweenSettings,
		Addressables_Configs_DataConfigs,
		Addressables_Configs_GameConfigs,
		Addressables_Configs_PieceAssetConfigs,
		Addressables_Configs_PieceSpriteAssetConfigs,
		Addressables_Configs_UiConfigs,
		Addressables_Pieces_Axe,
		Addressables_Pieces_Baby,
		Addressables_Pieces_Banana,
		Addressables_Pieces_Building,
		Addressables_Pieces_Cannon,
		Addressables_Pieces_CannonBall,
		Addressables_Pieces_Carrot,
		Addressables_Pieces_Cat,
		Addressables_Pieces_Cemetery,
		Addressables_Pieces_Cloud,
		Addressables_Pieces_CottonCandy,
		Addressables_Pieces_Deodorant,
		Addressables_Pieces_Dog,
		Addressables_Pieces_Egg,
		Addressables_Pieces_Flag,
		Addressables_Pieces_Foot,
		Addressables_Pieces_Hammer,
		Addressables_Pieces_Hills,
		Addressables_Pieces_House,
		Addressables_Pieces_Moon,
		Addressables_Pieces_Mushroom,
		Addressables_Pieces_Orange,
		Addressables_Pieces_Poop,
		Addressables_Pieces_Sword,
		Addressables_Pieces_Tire,
		Addressables_Pieces_Toilet,
		Addressables_Pieces_ToyBrick,
		Addressables_Pieces_ToySpaceship,
		Addressables_Pieces_TreeApple,
		Addressables_Pieces_UFO,
		Addressables_Sprites_Axe,
		Addressables_Sprites_Baby,
		Addressables_Sprites_Banana,
		Addressables_Sprites_Building,
		Addressables_Sprites_Cannon,
		Addressables_Sprites_CannonBall,
		Addressables_Sprites_Carrot,
		Addressables_Sprites_Cat,
		Addressables_Sprites_Cemetery,
		Addressables_Sprites_Cloud,
		Addressables_Sprites_CottonCandy,
		Addressables_Sprites_Deodorant,
		Addressables_Sprites_Dog,
		Addressables_Sprites_Egg,
		Addressables_Sprites_Flag,
		Addressables_Sprites_Foot,
		Addressables_Sprites_Hammer,
		Addressables_Sprites_Hills,
		Addressables_Sprites_House,
		Addressables_Sprites_Moon,
		Addressables_Sprites_Mushroom,
		Addressables_Sprites_Orange,
		Addressables_Sprites_Poop,
		Addressables_Sprites_Sword,
		Addressables_Sprites_Tire,
		Addressables_Sprites_Toilet,
		Addressables_Sprites_ToyBrick,
		Addressables_Sprites_ToySpaceship,
		Addressables_Sprites_Tree,
		Addressables_Sprites_UFO,
		Addressables_UI_GameOver,
		Addressables_UI_Loading_Screen,
		Addressables_UI_MainHud,
		Addressables_UI_Menu_Screen
	}

	public enum AddressableLabel
	{
		Label_GenerateIds
	}

	public static class AddressablePathLookup
	{
		public static readonly string AddressablesUI = "Addressables/UI";
		public static readonly string AddressablesSprites = "Addressables/Sprites";
		public static readonly string AddressablesPieces = "Addressables/Pieces";
		public static readonly string AddressablesConfigs = "Addressables/Configs";
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
					new AddressableConfig(0, "Addressables/UI/Menu Screen.prefab", "Assets/Addressables/UI/Menu Screen.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(1, "Addressables/UI/MainHud.prefab", "Assets/Addressables/UI/MainHud.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(2, "Addressables/UI/Loading Screen.prefab", "Assets/Addressables/UI/Loading Screen.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(3, "Addressables/UI/GameOver.prefab", "Assets/Addressables/UI/GameOver.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(4, "Addressables/Sprites/UFO.png", "Assets/Addressables/Sprites/UFO.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(5, "Addressables/Sprites/Tree.png", "Assets/Addressables/Sprites/Tree.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(6, "Addressables/Sprites/ToySpaceship.png", "Assets/Addressables/Sprites/ToySpaceship.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(7, "Addressables/Sprites/ToyBrick.png", "Assets/Addressables/Sprites/ToyBrick.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(8, "Addressables/Sprites/Toilet.png", "Assets/Addressables/Sprites/Toilet.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(9, "Addressables/Sprites/Tire.png", "Assets/Addressables/Sprites/Tire.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(10, "Addressables/Sprites/Sword.png", "Assets/Addressables/Sprites/Sword.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(11, "Addressables/Sprites/Poop.png", "Assets/Addressables/Sprites/Poop.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(12, "Addressables/Sprites/Orange.png", "Assets/Addressables/Sprites/Orange.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(13, "Addressables/Sprites/Mushroom.png", "Assets/Addressables/Sprites/Mushroom.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(14, "Addressables/Sprites/Moon.png", "Assets/Addressables/Sprites/Moon.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(15, "Addressables/Sprites/House.png", "Assets/Addressables/Sprites/House.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(16, "Addressables/Sprites/Hills.png", "Assets/Addressables/Sprites/Hills.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(17, "Addressables/Sprites/Hammer.png", "Assets/Addressables/Sprites/Hammer.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(18, "Addressables/Sprites/Foot.png", "Assets/Addressables/Sprites/Foot.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(19, "Addressables/Sprites/Flag.png", "Assets/Addressables/Sprites/Flag.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(20, "Addressables/Sprites/Egg.png", "Assets/Addressables/Sprites/Egg.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(21, "Addressables/Sprites/Dog.png", "Assets/Addressables/Sprites/Dog.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(22, "Addressables/Sprites/Deodorant.png", "Assets/Addressables/Sprites/Deodorant.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(23, "Addressables/Sprites/CottonCandy.png", "Assets/Addressables/Sprites/CottonCandy.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(24, "Addressables/Sprites/Cloud.png", "Assets/Addressables/Sprites/Cloud.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(25, "Addressables/Sprites/Cemetery.png", "Assets/Addressables/Sprites/Cemetery.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(26, "Addressables/Sprites/Cat.png", "Assets/Addressables/Sprites/Cat.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(27, "Addressables/Sprites/Carrot.png", "Assets/Addressables/Sprites/Carrot.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(28, "Addressables/Sprites/CannonBall.png", "Assets/Addressables/Sprites/CannonBall.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(29, "Addressables/Sprites/Cannon.png", "Assets/Addressables/Sprites/Cannon.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(30, "Addressables/Sprites/Building.png", "Assets/Addressables/Sprites/Building.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(31, "Addressables/Sprites/Banana.png", "Assets/Addressables/Sprites/Banana.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(32, "Addressables/Sprites/Baby.png", "Assets/Addressables/Sprites/Baby.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(33, "Addressables/Sprites/Axe.png", "Assets/Addressables/Sprites/Axe.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
					new AddressableConfig(34, "Addressables/Pieces/UFO.prefab", "Assets/Addressables/Pieces/UFO.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(35, "Addressables/Pieces/TreeApple.prefab", "Assets/Addressables/Pieces/TreeApple.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(36, "Addressables/Pieces/ToySpaceship.prefab", "Assets/Addressables/Pieces/ToySpaceship.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(37, "Addressables/Pieces/ToyBrick.prefab", "Assets/Addressables/Pieces/ToyBrick.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(38, "Addressables/Pieces/Toilet.prefab", "Assets/Addressables/Pieces/Toilet.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(39, "Addressables/Pieces/Tire.prefab", "Assets/Addressables/Pieces/Tire.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(40, "Addressables/Pieces/Sword.prefab", "Assets/Addressables/Pieces/Sword.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(41, "Addressables/Pieces/Poop.prefab", "Assets/Addressables/Pieces/Poop.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(42, "Addressables/Pieces/Orange.prefab", "Assets/Addressables/Pieces/Orange.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(43, "Addressables/Pieces/Mushroom.prefab", "Assets/Addressables/Pieces/Mushroom.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(44, "Addressables/Pieces/Moon.prefab", "Assets/Addressables/Pieces/Moon.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(45, "Addressables/Pieces/House.prefab", "Assets/Addressables/Pieces/House.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(46, "Addressables/Pieces/Hills.prefab", "Assets/Addressables/Pieces/Hills.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(47, "Addressables/Pieces/Hammer.prefab", "Assets/Addressables/Pieces/Hammer.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(48, "Addressables/Pieces/Foot.prefab", "Assets/Addressables/Pieces/Foot.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(49, "Addressables/Pieces/Flag.prefab", "Assets/Addressables/Pieces/Flag.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(50, "Addressables/Pieces/Egg.prefab", "Assets/Addressables/Pieces/Egg.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(51, "Addressables/Pieces/Dog.prefab", "Assets/Addressables/Pieces/Dog.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(52, "Addressables/Pieces/Deodorant.prefab", "Assets/Addressables/Pieces/Deodorant.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(53, "Addressables/Pieces/CottonCandy.prefab", "Assets/Addressables/Pieces/CottonCandy.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(54, "Addressables/Pieces/Cloud.prefab", "Assets/Addressables/Pieces/Cloud.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(55, "Addressables/Pieces/Cemetery.prefab", "Assets/Addressables/Pieces/Cemetery.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(56, "Addressables/Pieces/Cat.prefab", "Assets/Addressables/Pieces/Cat.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(57, "Addressables/Pieces/Carrot.prefab", "Assets/Addressables/Pieces/Carrot.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(58, "Addressables/Pieces/CannonBall.prefab", "Assets/Addressables/Pieces/CannonBall.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(59, "Addressables/Pieces/Cannon.prefab", "Assets/Addressables/Pieces/Cannon.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(60, "Addressables/Pieces/Building.prefab", "Assets/Addressables/Pieces/Building.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(61, "Addressables/Pieces/Banana.prefab", "Assets/Addressables/Pieces/Banana.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(62, "Addressables/Pieces/Baby.prefab", "Assets/Addressables/Pieces/Baby.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(63, "Addressables/Pieces/Axe.prefab", "Assets/Addressables/Pieces/Axe.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
					new AddressableConfig(64, "Addressables/Configs/UiConfigs.asset", "Assets/Addressables/Configs/UiConfigs.asset", typeof(GameLovers.UiService.UiConfigs), new [] {"GenerateIds"}),
					new AddressableConfig(65, "Addressables/Configs/PieceSpriteAssetConfigs.asset", "Assets/Addressables/Configs/PieceSpriteAssetConfigs.asset", typeof(Game.Configs.PieceSpriteAssetConfigs), new [] {"GenerateIds"}),
					new AddressableConfig(66, "Addressables/Configs/PieceAssetConfigs.asset", "Assets/Addressables/Configs/PieceAssetConfigs.asset", typeof(Game.Configs.PieceAssetConfigs), new [] {"GenerateIds"}),
					new AddressableConfig(67, "Addressables/Configs/GameConfigs.asset", "Assets/Addressables/Configs/GameConfigs.asset", typeof(Game.Configs.GameConfigs), new [] {"GenerateIds"}),
					new AddressableConfig(68, "Addressables/Configs/DataConfigs.asset", "Assets/Addressables/Configs/DataConfigs.asset", typeof(Game.Configs.DataConfigs), new [] {"GenerateIds"}),
					new AddressableConfig(69, "Addressables/Configs/DOTweenSettings.asset", "Assets/Addressables/Configs/DOTweenSettings.asset", typeof(DG.Tweening.Core.DOTweenSettings), new [] {"GenerateIds"}),
				}.AsReadOnly()}
		});

		private static readonly IList<AddressableConfig> _addressableConfigs = new List<AddressableConfig>
		{
			new AddressableConfig(0, "Addressables/Configs/DOTweenSettings.asset", "Assets/Addressables/Configs/DOTweenSettings.asset", typeof(DG.Tweening.Core.DOTweenSettings), new [] {"GenerateIds"}),
			new AddressableConfig(1, "Addressables/Configs/DataConfigs.asset", "Assets/Addressables/Configs/DataConfigs.asset", typeof(Game.Configs.DataConfigs), new [] {"GenerateIds"}),
			new AddressableConfig(2, "Addressables/Configs/GameConfigs.asset", "Assets/Addressables/Configs/GameConfigs.asset", typeof(Game.Configs.GameConfigs), new [] {"GenerateIds"}),
			new AddressableConfig(3, "Addressables/Configs/PieceAssetConfigs.asset", "Assets/Addressables/Configs/PieceAssetConfigs.asset", typeof(Game.Configs.PieceAssetConfigs), new [] {"GenerateIds"}),
			new AddressableConfig(4, "Addressables/Configs/PieceSpriteAssetConfigs.asset", "Assets/Addressables/Configs/PieceSpriteAssetConfigs.asset", typeof(Game.Configs.PieceSpriteAssetConfigs), new [] {"GenerateIds"}),
			new AddressableConfig(5, "Addressables/Configs/UiConfigs.asset", "Assets/Addressables/Configs/UiConfigs.asset", typeof(GameLovers.UiService.UiConfigs), new [] {"GenerateIds"}),
			new AddressableConfig(6, "Addressables/Pieces/Axe.prefab", "Assets/Addressables/Pieces/Axe.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(7, "Addressables/Pieces/Baby.prefab", "Assets/Addressables/Pieces/Baby.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(8, "Addressables/Pieces/Banana.prefab", "Assets/Addressables/Pieces/Banana.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(9, "Addressables/Pieces/Building.prefab", "Assets/Addressables/Pieces/Building.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(10, "Addressables/Pieces/Cannon.prefab", "Assets/Addressables/Pieces/Cannon.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(11, "Addressables/Pieces/CannonBall.prefab", "Assets/Addressables/Pieces/CannonBall.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(12, "Addressables/Pieces/Carrot.prefab", "Assets/Addressables/Pieces/Carrot.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(13, "Addressables/Pieces/Cat.prefab", "Assets/Addressables/Pieces/Cat.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(14, "Addressables/Pieces/Cemetery.prefab", "Assets/Addressables/Pieces/Cemetery.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(15, "Addressables/Pieces/Cloud.prefab", "Assets/Addressables/Pieces/Cloud.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(16, "Addressables/Pieces/CottonCandy.prefab", "Assets/Addressables/Pieces/CottonCandy.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(17, "Addressables/Pieces/Deodorant.prefab", "Assets/Addressables/Pieces/Deodorant.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(18, "Addressables/Pieces/Dog.prefab", "Assets/Addressables/Pieces/Dog.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(19, "Addressables/Pieces/Egg.prefab", "Assets/Addressables/Pieces/Egg.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(20, "Addressables/Pieces/Flag.prefab", "Assets/Addressables/Pieces/Flag.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(21, "Addressables/Pieces/Foot.prefab", "Assets/Addressables/Pieces/Foot.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(22, "Addressables/Pieces/Hammer.prefab", "Assets/Addressables/Pieces/Hammer.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(23, "Addressables/Pieces/Hills.prefab", "Assets/Addressables/Pieces/Hills.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(24, "Addressables/Pieces/House.prefab", "Assets/Addressables/Pieces/House.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(25, "Addressables/Pieces/Moon.prefab", "Assets/Addressables/Pieces/Moon.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(26, "Addressables/Pieces/Mushroom.prefab", "Assets/Addressables/Pieces/Mushroom.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(27, "Addressables/Pieces/Orange.prefab", "Assets/Addressables/Pieces/Orange.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(28, "Addressables/Pieces/Poop.prefab", "Assets/Addressables/Pieces/Poop.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(29, "Addressables/Pieces/Sword.prefab", "Assets/Addressables/Pieces/Sword.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(30, "Addressables/Pieces/Tire.prefab", "Assets/Addressables/Pieces/Tire.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(31, "Addressables/Pieces/Toilet.prefab", "Assets/Addressables/Pieces/Toilet.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(32, "Addressables/Pieces/ToyBrick.prefab", "Assets/Addressables/Pieces/ToyBrick.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(33, "Addressables/Pieces/ToySpaceship.prefab", "Assets/Addressables/Pieces/ToySpaceship.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(34, "Addressables/Pieces/TreeApple.prefab", "Assets/Addressables/Pieces/TreeApple.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(35, "Addressables/Pieces/UFO.prefab", "Assets/Addressables/Pieces/UFO.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(36, "Addressables/Sprites/Axe.png", "Assets/Addressables/Sprites/Axe.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(37, "Addressables/Sprites/Baby.png", "Assets/Addressables/Sprites/Baby.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(38, "Addressables/Sprites/Banana.png", "Assets/Addressables/Sprites/Banana.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(39, "Addressables/Sprites/Building.png", "Assets/Addressables/Sprites/Building.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(40, "Addressables/Sprites/Cannon.png", "Assets/Addressables/Sprites/Cannon.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(41, "Addressables/Sprites/CannonBall.png", "Assets/Addressables/Sprites/CannonBall.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(42, "Addressables/Sprites/Carrot.png", "Assets/Addressables/Sprites/Carrot.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(43, "Addressables/Sprites/Cat.png", "Assets/Addressables/Sprites/Cat.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(44, "Addressables/Sprites/Cemetery.png", "Assets/Addressables/Sprites/Cemetery.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(45, "Addressables/Sprites/Cloud.png", "Assets/Addressables/Sprites/Cloud.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(46, "Addressables/Sprites/CottonCandy.png", "Assets/Addressables/Sprites/CottonCandy.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(47, "Addressables/Sprites/Deodorant.png", "Assets/Addressables/Sprites/Deodorant.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(48, "Addressables/Sprites/Dog.png", "Assets/Addressables/Sprites/Dog.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(49, "Addressables/Sprites/Egg.png", "Assets/Addressables/Sprites/Egg.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(50, "Addressables/Sprites/Flag.png", "Assets/Addressables/Sprites/Flag.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(51, "Addressables/Sprites/Foot.png", "Assets/Addressables/Sprites/Foot.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(52, "Addressables/Sprites/Hammer.png", "Assets/Addressables/Sprites/Hammer.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(53, "Addressables/Sprites/Hills.png", "Assets/Addressables/Sprites/Hills.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(54, "Addressables/Sprites/House.png", "Assets/Addressables/Sprites/House.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(55, "Addressables/Sprites/Moon.png", "Assets/Addressables/Sprites/Moon.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(56, "Addressables/Sprites/Mushroom.png", "Assets/Addressables/Sprites/Mushroom.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(57, "Addressables/Sprites/Orange.png", "Assets/Addressables/Sprites/Orange.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(58, "Addressables/Sprites/Poop.png", "Assets/Addressables/Sprites/Poop.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(59, "Addressables/Sprites/Sword.png", "Assets/Addressables/Sprites/Sword.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(60, "Addressables/Sprites/Tire.png", "Assets/Addressables/Sprites/Tire.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(61, "Addressables/Sprites/Toilet.png", "Assets/Addressables/Sprites/Toilet.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(62, "Addressables/Sprites/ToyBrick.png", "Assets/Addressables/Sprites/ToyBrick.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(63, "Addressables/Sprites/ToySpaceship.png", "Assets/Addressables/Sprites/ToySpaceship.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(64, "Addressables/Sprites/Tree.png", "Assets/Addressables/Sprites/Tree.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(65, "Addressables/Sprites/UFO.png", "Assets/Addressables/Sprites/UFO.png", typeof(UnityEngine.Texture2D), new [] {"GenerateIds"}),
			new AddressableConfig(66, "Addressables/UI/GameOver.prefab", "Assets/Addressables/UI/GameOver.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(67, "Addressables/UI/Loading Screen.prefab", "Assets/Addressables/UI/Loading Screen.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(68, "Addressables/UI/MainHud.prefab", "Assets/Addressables/UI/MainHud.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"}),
			new AddressableConfig(69, "Addressables/UI/Menu Screen.prefab", "Assets/Addressables/UI/Menu Screen.prefab", typeof(UnityEngine.GameObject), new [] {"GenerateIds"})
		}.AsReadOnly();
	}
}
