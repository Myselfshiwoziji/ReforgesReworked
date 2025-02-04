using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;

namespace ReforgesReworked.Content.Prefix
{
    public class Focused : ModPrefix
    {
        public virtual float Power => 1f;

        public override PrefixCategory Category => PrefixCategory.Magic;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1f + 0.3f * Power;
            useTimeMult *= 1f - 0.25f * Power;
            shootSpeedMult *= 1f + 0.35f * Power;
            manaMult *= 1f + 0.85f * Power;
            knockbackMult *= 1f - 0.3f * Power;
            critBonus += 5;
        }
    }

    public class Explosive : ModPrefix
    {
        public virtual float Power => 1f;

        public override PrefixCategory Category => PrefixCategory.Magic;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1f - 0.05f * Power;
            useTimeMult *= 1f - 0.25f * Power;
            shootSpeedMult *= 1f + 0.7f * Power;
            manaMult *= 1f + 0.2f * Power;
            knockbackMult *= 1f + 0.5f * Power;
            critBonus += 20;
        }
    }

    public class Volatile : ModPrefix
    {
        public virtual float Power => 1f;
         public virtual int AbsolutePower => 1;

        public override PrefixCategory Category => PrefixCategory.Magic;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1f - 0.5f * Power;
            useTimeMult *= 1f - 0.75f * Power;
            shootSpeedMult *= 1f + 0.25f * Power;
            manaMult *= 1f - 0.3f * Power;
            critBonus += -10 * AbsolutePower;
        }
    }

    public class Proficient : ModPrefix
    {
        public virtual float Power => 1f;
         public virtual int AbsolutePower => 1;

        public override PrefixCategory Category => PrefixCategory.Magic;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1f + 0.2f * Power;
            useTimeMult *= 1f - 0.05f * Power;
            critBonus += 10 * AbsolutePower;
        }
    }
}