// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;

namespace ReforgesReworked.Content.Prefix
{
    public class Lunatic : ModPrefix
    {
        public virtual float Power => 1f;

        public override PrefixCategory Category => PrefixCategory.Ranged;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            shootSpeedMult *= 1f + 0.3f * Power;
            useTimeMult *= 1f - 0.5f * Power;
            damageMult *= 1f - 0.3f * Power;
            critBonus += 5;
        }
    }

    public class Laidback : ModPrefix
    {
        public virtual float Power => 1f;

        public override PrefixCategory Category => PrefixCategory.Ranged;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            return true;
        }

		public override void ModifyValue(ref float valueMult) {
			valueMult *= 1f + 0.15f * Power;
		}

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1f + 0.67f * Power;
            useTimeMult *= 1f + 0.23f * Power;
            shootSpeedMult *= 1f - 0.26f * Power;
            critBonus += 18;
        }
    }

    public class Exhaustive : ModPrefix
    {
        public virtual float Power => 1f;

        public override PrefixCategory Category => PrefixCategory.Ranged;

        public override float RollChance(Item item) {
            return 50f;
        }

        public override bool CanRoll(Item item) 
        {
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            useTimeMult *= 1f + 0.1f * Power;
            damageMult *= 1f + 0.35f * Power;
            shootSpeedMult *= 1f + 0.8f * Power;
        }
    }

    public class Sharpshooter : ModPrefix
    {
        public virtual float Power => 1f;

        public override PrefixCategory Category => PrefixCategory.Ranged;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            useTimeMult *= 1f - 0.08f * Power;
            damageMult *= 1f + 0.27f * Power;
            shootSpeedMult *= 1f + 0.15f * Power;
            critBonus += -15;
        }
    }

    public class Marksman : ModPrefix
    {
        public virtual float Power => 1f;

        public override PrefixCategory Category => PrefixCategory.Ranged;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            useTimeMult *= 1f + 0.1f * Power;
            shootSpeedMult *= 1f + 0.1f * Power;
            critBonus += 45;
        }
    }
}