using Terraria;
using Terraria.ModLoader;

namespace ReforgesReworked.Content.Dusts
{
	/// <summary>
	/// This debuff reduces enemy armor by 25%. Use <see cref="Content.Items.Weapons.HitModifiersShowcase"/> or <see cref="Items.Consumables.ExampleFlask"/> to apply.
	/// By using a buff we can apply to both players and NPCs, and also rely on vanilla to sync the AddBuff calls so we don't need to write our own netcode
	/// </summary>
	public class ShiDebuff : ModBuff
	{
		public const int DebuffDamage = 9999;

		public override void SetStaticDefaults() {
			Main.pvpBuff[Type] = true; // This buff can be applied by other players in Pvp, so we need this to be true.
		}

		public override void Update(NPC npc, ref int buffIndex) {
            npc.life = 1;
            // for (int i = 0; i < 40; i++) {
            //     npc.life -= DebuffDamage * (i+1);
            // }
		}

		public override void Update(Player player, ref int buffIndex) {
            for (int i = 0; i < 10; i++) {
                player.statLife -= DebuffDamage;
                player.statLife = 0;
            }
		}
	}
}