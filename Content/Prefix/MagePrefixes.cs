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
    public class Focused : ModPrefix
    {
        public virtual float Power => 0f;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Magic;

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
            valueMult *= 1.15f * Power;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1.25f + 0.25f * Power;
            useTimeMult *= 0.85f - 0.15f * Power;
            shootSpeedMult *= 1.18f + 0.22f * Power;
            manaMult *= 1.5f + 0.15f * Power;
            knockbackMult *= 0.9f - 0.2f * Power;
            critBonus += 5 + Convert.ToInt32(2f * Power);
        }
    }

    public class Explosive : ModPrefix
    {
        public virtual float Power => 0f;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Magic;

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
            valueMult *= 1.3f * Power;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1.05f + 0.05f * Power;
            useTimeMult *= 0.8f - 0.3f * Power;
            shootSpeedMult *= 1.7f + 0.45f * Power;
            manaMult *= 1.2f + 0.25f * Power;
            knockbackMult *= 1.5f + 0.35f * Power;
            critBonus += 20;
        }
    }

    public class Volatile : ModPrefix
    {
        public virtual float Power => 0f;
        public virtual int AbsolutePower => 0;
        public virtual int MinimumPrefixTier => 1;

        public override PrefixCategory Category => PrefixCategory.Magic;

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
            damageMult *= 0.52f + 0.14f * Power;
            useTimeMult *= 0.35f - 0.1f * Power;
            shootSpeedMult *= 1.25f + 0.15f * Power;
            manaMult *= 0.7f + 0.15f * Power;
            critBonus += -15 - 3 * AbsolutePower;
        }
    }

    public class Proficient : ModPrefix
    {
        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Magic;

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
            damageMult *= 1.2f + 0.2f * Power;
            useTimeMult *= 0.95f - 0.05f * Power;
            critBonus += 10 * AbsolutePower;
            manaMult *= 1f - 0.05f * Power;
        }
    }

    public class Charged : ModPrefix
    {
        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int MinimumPrefixTier => 0; 

        public override PrefixCategory Category => PrefixCategory.Magic;

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
            damageMult *= 1.65f + 0.25f * Power;
            useTimeMult *= 1.35f + 0.15f * Power;
            critBonus += 10 * AbsolutePower;
            manaMult *= 1.12f + 0.05f * Power;
        }
    }
}