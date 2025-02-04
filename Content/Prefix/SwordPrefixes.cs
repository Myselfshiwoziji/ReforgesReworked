using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;

namespace ReforgesReworked.Content.Prefix
{
    public class Gigantic : ModPrefix
    {
        public virtual float Power => 1f;

        public override PrefixCategory Category => PrefixCategory.Melee;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1f + 0.1f * Power;
            useTimeMult *= 1f + 0.3f * Power; 
            scaleMult *= 1f + 0.8f * Power;
            knockbackMult *= 1f + 0.8f * Power;
        }
    }

    public class Razorsharp : ModPrefix
    {
        public virtual float Power => 1f;

        public override PrefixCategory Category => PrefixCategory.Melee;

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
            knockbackMult *= 1f - 0.3f * Power;
            critBonus += 30;
            useTimeMult *= 1f + 0.2f * Power;
            damageMult *= 1f + 0.05f * Power;
        }
    }

    public class Dynamic : ModPrefix
    {
        public virtual float Power => 1f;

        public override PrefixCategory Category => PrefixCategory.Melee;

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
            damageMult *= 1f - 0.23f * Power;
            useTimeMult *= 1f - 0.6f * Power;
            scaleMult *= 1f + 0.1f * Power;
            knockbackMult *= 1f - 0.7f * Power;

        }
    }

    public class Extensive : ModPrefix
    {
        public virtual float Power => 1f;

        public override PrefixCategory Category => PrefixCategory.Melee;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            useTimeMult *= 1f + 0.1f * Power; 
            damageMult *= 1f + 0.27f * Power;
            scaleMult *= 1f + 0.4f * Power;
            knockbackMult *= 1f + 0.15f * Power;
        }
    }
}