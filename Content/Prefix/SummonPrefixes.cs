using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;

namespace ReforgesReworked.Content.Prefix 
{
    public class BaseSummonPrefix : ModPrefix
    {
        public virtual float Power => 1f;

        public override PrefixCategory Category => PrefixCategory.AnyWeapon;

        public override float RollChance(Item item) {
            return 50f;
        }

        public override bool CanRoll(Item item) 
        {
            if (item.DamageType == DamageClass.Summon) {
                return false;   
            }
            else {
                return false;
            }
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1f + 0.20f * Power; // damage +20%
        }
    }
}