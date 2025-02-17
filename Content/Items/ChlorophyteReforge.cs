using System.Drawing;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using System;
using Content.PlayerStats;
using ReforgesReworked.Content.Config;

namespace ReforgesReworked.Content.Items
{
	internal class ChlorophyteReforge : ModItem
	{

        public int PrefixTier = 2;
        public override bool CanUseItem(Player player)
        {
            return player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier == PrefixTier - 1;
        }

        public override bool? UseItem(Player player) {
            if (player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier == 1) {
                player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier++;
                Main.NewText($"You can now get tier {player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier + 1} reforges!", Colors.RarityRed);
                return true;
            }
            else if (player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier > 1) {
                Main.NewText("You have already used this item!");
                return null;
            }
            else {
                Main.NewText("You do not have enough reforge tiers to use this item!");
                return null;
            }
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ManaCrystal);
        }
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<HardmodeReforge>(), 1);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 40);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}