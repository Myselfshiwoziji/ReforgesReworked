using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using ReforgesReworked.Content.Config;

namespace ReforgesReworked.Content.Vanilla {

    public class AccessoryPrefix : GlobalItem {

        public override bool IsLoadingEnabled(Mod mod) {

            return ModContent.GetInstance<PrefixConfig>().DisableVanillaPrefixToggle;
        }

        public override bool InstancePerEntity => true;

        public int[] AccessoryPrefixArray = {
            PrefixID.Hard, PrefixID.Guarding, PrefixID.Armored, PrefixID.Warding, //Defense modifiers
            PrefixID.Precise, PrefixID.Lucky, //Crit chance modifiers
            PrefixID.Jagged, PrefixID.Spiked, PrefixID.Angry, PrefixID.Menacing, //Damage modifiers
            PrefixID.Brisk, PrefixID.Fleeting, PrefixID.Hasty, PrefixID.Quick, //Movement modifiers
            PrefixID.Wild, PrefixID.Intrepid, PrefixID.Rash, PrefixID.Violent, //Attack speed modifiers
            PrefixID.Arcane //Mana modifiers
        };

        public int[] WeaponPrefixArray = {
            //Universal modifiers
            PrefixID.Keen, PrefixID.Superior, PrefixID.Forceful, PrefixID.Broken, PrefixID.Damaged, 
            PrefixID.Shoddy, PrefixID.Strong, PrefixID.Hurtful, PrefixID.Unpleasant, PrefixID.Weak, 
            PrefixID.Ruthless, PrefixID.Godly, PrefixID.Demonic, PrefixID.Zealous,

            //Common modifiers
            PrefixID.Quick, PrefixID.Deadly, PrefixID.Agile, PrefixID.Nimble, PrefixID.Slow, PrefixID.Murderous, 
            PrefixID.Sluggish, PrefixID.Lazy, PrefixID.Nasty, PrefixID.Annoying, PrefixID.Slow,

            //Melee modifiers
            PrefixID.Large, PrefixID.Massive, PrefixID.Dangerous, PrefixID.Savage, PrefixID.Pointy, PrefixID.Sharp, PrefixID.Tiny,
            PrefixID.Terrible, PrefixID.Small, PrefixID.Dull, PrefixID.Unhappy, PrefixID.Bulky, PrefixID.Heavy, PrefixID.Shameful,
            PrefixID.Light,

            //Ranged modifiers
            PrefixID.Sighted, PrefixID.Rapid, PrefixID.Hasty, PrefixID.Intimidating, PrefixID.Deadly, PrefixID.Staunch, PrefixID.Awful, PrefixID.Lethargic, 
            PrefixID.Awkward, PrefixID.Powerful, PrefixID.Frenzying,

            //Magic modifiers
            PrefixID.Mystic, PrefixID.Adept, PrefixID.Masterful, PrefixID.Inept, PrefixID.Ignorant, PrefixID.Deranged, PrefixID.Taboo, PrefixID.Intense,
            PrefixID.Celestial, PrefixID.Furious, PrefixID.Manic,

            //Summon modifiers
            //oh right they dont exist lmao :rofl:
        };

        public override bool AllowPrefix(Item item, int pre) {
            if (item.damage > 0) {
                foreach (int VanillaPrefix in WeaponPrefixArray) {
                    if (pre == VanillaPrefix) {
                        return false;
                    }
                }
                return true;
            }
            else {
                foreach (int VanillaPrefix in AccessoryPrefixArray) {
                    if (pre == VanillaPrefix) {
                        return false;
                    }
                }
                return true;
            }
        }

    }
}
