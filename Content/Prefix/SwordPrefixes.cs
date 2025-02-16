// using System;
using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Content.PlayerStats;
using Terraria.GameContent.UI.Minimap;
using System;

namespace ReforgesReworked.Content.Prefix
{ 
    public class Gigantic : ModPrefix
    {
        public virtual float Power => 0f;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Melee;

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
            valueMult *= 1f + 0.3f * Power;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1.1f + Power * 0.05f;
            useTimeMult *= 1.3f - 0.1f * Power; 
            scaleMult *= 1.3f + 0.45f * Power;
            knockbackMult *= 1.5f + 0.5f * Power;
        }
    }

    public class Razorsharp : ModPrefix
    {
        public virtual float Power => 0f;
        public virtual double AbsolutePower => 1;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Melee;

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
            knockbackMult *= 0.7f + 0.1f * Power;
            critBonus += Convert.ToInt32(30 * AbsolutePower);
            useTimeMult *= 1.07f - 0.3f * Power;
            damageMult *= 1.05f + 0.05f * Power;
        }
    }

    public class Dynamic : ModPrefix
    {
        public virtual float Power => 0f;

        public override PrefixCategory Category => PrefixCategory.Melee;
        public virtual int MinimumPrefixTier => 0;

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
			valueMult *= 1.5f + 0.5f * Power;
		}

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 0.65f + 0.15f * Power;
            useTimeMult *= 0.55f - 0.05f * Power;
            scaleMult *= 1.1f + 0.15f * Power;
            knockbackMult *= 0.3f + 0.2f * Power;

        }
    }

    public class Extensive : ModPrefix
    {
        public virtual float Power => 1f;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Melee;

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
            valueMult *= 1f + 0.15f * (Power - 1f);
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            useTimeMult *= 1f + 0.07f * Power; 
            damageMult *= 1f + 0.3f * Power;
            scaleMult *= 1f + 0.35f * Power;
            knockbackMult *= 1f + 0.15f * Power;
        }
    }

    public class Comical : ModPrefix
    {
        public virtual float Power => 1f;

        public virtual int MinimumPrefixTier => 2;

        public override PrefixCategory Category => PrefixCategory.Melee;

        public override float RollChance(Item item) {
            return 0.2f;
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
            damageMult *= 1f - 0.69f * Power;
            useTimeMult *= 1f - 0.69f * Power; 
            scaleMult *= 1f + 2f * Power;
            knockbackMult *= 1f + 2f * Power;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item) {
            var tooltip_joke = new TooltipLine(Mod, "PrefixJoke", $"Yes, this is a joke reforge. Atleast its good for events?");

            yield return tooltip_joke;
        }
    }

    public class Honed : ModPrefix
    {
        public virtual float Power => 1f;
        public virtual double AbsolutePower => 1;

        public override PrefixCategory Category => PrefixCategory.Melee;
        public virtual int MinimumPrefixTier => 0;

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
            valueMult *= 1f + 0.4f * Power;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
            damageMult *= 1.2f + 0.2f * Power;
            useTimeMult *= 0.96f - 0.03f * Power;
            scaleMult *= 0.85f + 0.10f * Power;
            knockbackMult *= 0.87f - 0.05f * Power;
            critBonus += -1 * Convert.ToInt32(5 + 5 * AbsolutePower);
        }
    }
}