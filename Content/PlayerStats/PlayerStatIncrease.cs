using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Content.PlayerStats {

    public class PlayerReforgeTier : ModPlayer {
        public int HardmodeReforgeUnlocked;
        public int ChlorophyteReforgeUnlocked;

        public int PlayerPrefixTier;

        public int? CurrentPrefixTier(Player player) {
            // Main.NewText($"Tier is {player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier}");
            if (player.active) {
                return player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier;
            }

            return 0;
        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
        {
            ModPacket packet = Mod.GetPacket();
            packet.Write((byte)Player.whoAmI);
            packet.Write((byte)PlayerPrefixTier);
            packet.Send(toWho, fromWho);
        }

        public override void SaveData(TagCompound tag)
        {
            tag["PlayerPrefixTier"] = PlayerPrefixTier;
        }

        public override void LoadData(TagCompound tag)
        {
            PlayerPrefixTier = tag.GetInt("PlayerPrefixTier");
        }
    }
}