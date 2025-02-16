using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Content.PlayerStats;
using ReforgesReworked.Content.Config;

namespace ReforgesReworked.Content.Items
{
	internal class DebugReforge : ModItem
	{
		public static readonly int TierZeroReforge = 1;

		public override bool IsLoadingEnabled(Mod mod) {

            return ModContent.GetInstance<DebugConfig>().Debug;
        }   

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