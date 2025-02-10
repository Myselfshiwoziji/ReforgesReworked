// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;

namespace ReforgesReworked.Content.TestPrefix 
{
    public class TestPrefix : ModPrefix
    {
        public virtual float Power => 1f;

        public override PrefixCategory Category => PrefixCategory.AnyWeapon;

        public override float RollChance(Item item) {
            return 50f;
        }

        public override bool CanRoll(Item item) 
        {
            return false;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1f + 0.20f * Power; // damage +20%
            useTimeMult *= 1f - 0.5f * Power; // Use time + 50%, or 50% faster
            scaleMult *= 1f + 3f * Power; // size +300%
        }
    }
}