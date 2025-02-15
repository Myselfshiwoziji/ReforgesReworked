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
            // player.GetModPlayer<PlayerReforgeTier>().ChlorophyteReforgeUnlocked = 0;
            // player.GetModPlayer<PlayerReforgeTier>().HardmodeReforgeUnlocked = 0;
            Main.NewText($"Reforge tier was previously {player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier}");
            player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier = 0;
            Main.NewText($"Reforge tier is reset to {player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier}");
            return true;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ManaCrystal);
        }
	}
}