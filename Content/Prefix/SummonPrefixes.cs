// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;

namespace ReforgesReworked.Content.Prefix 
{
    public class Commandneering : ModPrefix // doesn't work rn
    {

        public virtual float Power => 1f;
        public virtual float AbsolutePower => 1f;
        public virtual float RollPower => 1f;

        public override PrefixCategory Category => PrefixCategory.AnyWeapon;

        public override float RollChance(Item item) {
            return 1f;
        }

        public override bool CanRoll(Item item) 
        {
            if (item.DamageType == DamageClass.Summon) {
                return true;   
            }
            else {
                return false;
            }
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1f - 0.30f * Power;
            useTimeMult *= 1f - 0.30f * Power;
            scaleMult *= 1f + 0.5f * Power;
        }
    }
}