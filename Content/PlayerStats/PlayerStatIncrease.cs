using ReforgesReworked.Content.Items;
using System.IO;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Testing;

namespace Content.PlayerStats {

    public class PlayerReforgeTier : ModPlayer {
        public int HardmodeReforgeUnlocked;
        public int ChlorophyteReforgeUnlocked;

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
        {
            ModPacket packet = Mod.GetPacket();
            packet.Write((byte)Player.whoAmI);
            packet.Write((byte)HardmodeReforgeUnlocked);
            packet.Write((byte)ChlorophyteReforgeUnlocked);
            packet.Send(toWho, fromWho);
        }

        public override void SaveData(TagCompound tag)
        {
            tag["HardmodeReforgeUnlocked"] = HardmodeReforgeUnlocked;
            tag["ChlorophyteReforgeUnlocked"] = ChlorophyteReforgeUnlocked;
        }

        public override void LoadData(TagCompound tag)
        {
            HardmodeReforgeUnlocked = tag.GetInt("HardmodeReforgeUnlocked");
            ChlorophyteReforgeUnlocked = tag.GetInt("ChlorophyteReforgeUnlocked");
        }
    }
}