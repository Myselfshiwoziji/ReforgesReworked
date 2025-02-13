using System.Drawing;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using ReforgesReworked.Content.Items;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using System;
using Content.PlayerStats;

namespace ReforgesReworked.Content.Items
{
	internal class DebugReforge : ModItem
	{
		public static readonly int TierZeroReforge = 1;

        public override bool CanUseItem(Player player)
        {
            return true;
        }

        public override bool? UseItem(Player player) {
            player.GetModPlayer<PlayerReforgeTier>().ChlorophyteReforgeUnlocked = 0;
            player.GetModPlayer<PlayerReforgeTier>().HardmodeReforgeUnlocked = 0;
            return true;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ManaCrystal);
        }

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		// public override void AddRecipes()
		// {
		// 	Recipe recipe = CreateRecipe();
		// 	recipe.AddIngredient(ModContent.ItemType<HardmodeReforge>(), 1);
        //     recipe.AddIngredient(ItemID.ChlorophyteBar, 40);
		// 	recipe.AddTile(TileID.MythrilAnvil);
		// 	recipe.Register();
		// }
	}
}