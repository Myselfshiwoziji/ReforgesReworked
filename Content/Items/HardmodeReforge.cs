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
	internal class HardmodeReforge : ModItem
	{
		public static readonly int TierTwoReforge = 1;

		public override bool? UseItem(Player player) {
            if (player.GetModPlayer<PlayerReforgeTier>().HardmodeReforgeUnlocked > 1) {
                return null;
            }
            player.GetModPlayer<PlayerReforgeTier>().HardmodeReforgeUnlocked += 2;
            Main.NewText("You can now get tier 2 reforges!", Colors.RarityGreen);
            return true;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ManaCrystal);
        }

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Pwnhammer, 1);
            recipe.AddIngredient(ItemID.PalladiumBar, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.Pwnhammer, 1);
            recipe2.AddIngredient(ItemID.CobaltBar, 20);
			recipe2.AddTile(TileID.Anvils);
			recipe2.Register();
		}
	}
}