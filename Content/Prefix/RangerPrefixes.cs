// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using System;
using Content.PlayerStats;

namespace ReforgesReworked.Content.Prefix
{
    public class Lunatic : ModPrefix
    {
        public virtual float Power => 0f;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Ranged;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            Player player = Main.player[Main.myPlayer];
            if (player.active) {
                int PlayerTier = player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier;
                return PlayerTier >= MinimumPrefixTier;
            }

            return true;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1f + 0.25f * Power;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            shootSpeedMult *= 1.3f + 0.1f * Power;
            useTimeMult *= 0.5f - 0.1f * Power;
            damageMult *= 0.3f - 0.05f * Power;
            critBonus += 5 + 3 * Convert.ToInt32(Power);
        }
    }

    public class Laidback : ModPrefix
    {
        public virtual float Power => 0f;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Ranged;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            Player player = Main.player[Main.myPlayer];
            if (player.active) {
                int PlayerTier = player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier;
                return PlayerTier >= MinimumPrefixTier;
            }

            return true;
        }

		public override void ModifyValue(ref float valueMult) {
			valueMult *= 1f + 0.15f * Power;
		}

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1.67f + 0.13f * Power;
            useTimeMult *= 1.23f - 0.03f * Power;
            shootSpeedMult *= 0.74f + 0.11f * Power;
            critBonus += 18;
        }
    }

    public class Exhaustive : ModPrefix
    {
        public virtual float Power => 0f;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Ranged;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            Player player = Main.player[Main.myPlayer];
            if (player.active) {
                int PlayerTier = player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier;
                return PlayerTier >= MinimumPrefixTier;
            }

            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            useTimeMult *= 1.1f - 0.07f * Power;
            damageMult *= 1.35f + 0.15f * Power;
            shootSpeedMult *= 1.8f + 0.4f * Power;
        }
    }

    public class Sharpshooter : ModPrefix
    {
        public virtual float Power => 1f;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Ranged;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            Player player = Main.player[Main.myPlayer];
            if (player.active) {
                int PlayerTier = player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier;
                return PlayerTier >= MinimumPrefixTier;
            }

            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            useTimeMult *= 0.92f - 0.12f * Power;
            damageMult *= 1.27f + 0.13f * Power;
            shootSpeedMult *= 1.15f + 0.25f * Power;
            critBonus += -15 + 5 * Convert.ToInt32(Power);
        }
    }

    public class Marksman : ModPrefix
    {
        public virtual float Power => 0f;
        public virtual int MinimumPrefixTier => 1;

        public override PrefixCategory Category => PrefixCategory.Ranged;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            Player player = Main.player[Main.myPlayer];
            if (player.active) {
                int PlayerTier = player.GetModPlayer<PlayerReforgeTier>().PlayerPrefixTier;
                return PlayerTier >= MinimumPrefixTier;
            }

            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1f + 0.1f * Power;
            useTimeMult *= 1.1f - 0.15f * Power;
            shootSpeedMult *= 1.1f + 0.3f * Power;
            critBonus += 45 + 25 * Convert.ToInt32(Power);
        }
    }
}