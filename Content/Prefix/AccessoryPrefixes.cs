using System;
using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Content.PlayerStats;
using ReforgesReworked.Content.Items;
using Terraria.DataStructures;
using System.Security.Cryptography.X509Certificates;
using Mono.Cecil.Cil;

namespace ReforgesReworked.Content.Prefix
{
    public class Vampiric : ModPrefix
    {
        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;
        public virtual int MinimumPrefixTier => 1;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            player.statLifeMax2 += 30 * AbsolutePower;
            player.statDefense += -1 * AbsolutePower;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            int final_health_prefix = 30 * AbsolutePower;
            int final_defense_prefix = -1 * AbsolutePower;
            var tooltip_health = new TooltipLine(Mod, "PrefixMaxHealth", $"+{final_health_prefix} max health");
            var tooltip_defense = new TooltipLine(Mod, "PrefixDefense", $"{final_defense_prefix} defense");
            tooltip_health.IsModifier = true;
            tooltip_defense.IsModifier = true;
            tooltip_defense.IsModifierBad = true;
            yield return tooltip_health;
            yield return tooltip_defense;
        }
    }

    public class Spiritual : ModPrefix {

        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;
        public virtual int MinimumPrefixTier => 1;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            player.manaRegenBonus += 5 * AbsolutePower;
            player.manaRegenDelay *= 1f - 0.03f * Power;
            player.statManaMax2 += -10 * AbsolutePower;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            int final_manaregen_prefix = 5 * AbsolutePower;
            float final_manadelay_prefix = 3f * Power;
            int final_maxmana_prefix = 10 * AbsolutePower;
            var tooltip_manaregen = new TooltipLine(Mod, "PrefixManaRegen", $"+{final_manaregen_prefix} mana regen");
            var tooltip_manadelay = new TooltipLine(Mod, "PrefixManaRegenDelay", $"-{final_manadelay_prefix}% mana regen delay");
            var tooltip_maxmana = new TooltipLine(Mod, "PrefixMaxMana", $"-{final_maxmana_prefix} max mana");

            tooltip_manaregen.IsModifier = true;
            tooltip_manadelay.IsModifier = true;
            tooltip_maxmana.IsModifier = true;
            tooltip_maxmana.IsModifierBad = true;

            yield return tooltip_manaregen;
            yield return tooltip_manadelay;
            yield return tooltip_maxmana;
        }
    }

    public class Gambling : ModPrefix {

        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            player.GetDamage(DamageClass.Generic) *= 1f - 0.03f * Power;
            player.GetCritChance(DamageClass.Generic) += 5 * AbsolutePower;

        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            float final_damage = 3f * Power;
            int final_crit = 5 * AbsolutePower;
            var tooltip_final_damage = new TooltipLine(Mod, "PrefixFinalDamage", $"-{final_damage}% damage");
            var tooltip_final_crit = new TooltipLine(Mod, "PrefixFinalCrit", $"+{final_crit}% crit chance");

            tooltip_final_damage.IsModifier = true;
            tooltip_final_damage.IsModifierBad = true;
            tooltip_final_crit.IsModifier = true;

            yield return tooltip_final_damage;
            yield return tooltip_final_crit;

        }
    }

    public class Exposed : ModPrefix {

        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;

        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            player.GetDamage(DamageClass.Generic) *= 1f + 0.05f * Power;
            player.statDefense += -1 * AbsolutePower;

        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            float final_damage = 5f * Power;
            int final_defense = 1 * AbsolutePower;
            var tooltip_final_damage = new TooltipLine(Mod, "PrefixFinalDamage", $"+{final_damage}% damage");
            var tooltip_final_defense = new TooltipLine(Mod, "PrefixFinalDefense", $"-{final_defense} defense");

            tooltip_final_damage.IsModifier = true;
            tooltip_final_defense.IsModifier = true;
            tooltip_final_defense.IsModifierBad = true;


            yield return tooltip_final_damage;
            yield return tooltip_final_defense;

        }
    }

    public class Symbiotic : ModPrefix {

        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            player.GetDamage(DamageClass.Summon) *= 1f - 0.08f * Power;
            player.maxMinions += 1 * AbsolutePower;

        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            float final_summon = 8f * Power;
            int final_minion = 1 * AbsolutePower;
            var tooltip_final_summon = new TooltipLine(Mod, "PrefixFinalSummon", $"-{final_summon}% summon damage");
            var tooltip_final_minion = new TooltipLine(Mod, "PrefixFinalMinion", $"+{final_minion} summon slots");

            tooltip_final_minion.IsModifier = true;
            tooltip_final_summon.IsModifier = true;
            tooltip_final_summon.IsModifierBad = true;


            yield return tooltip_final_minion;
            yield return tooltip_final_summon;

        }
    }

    public class Lonely : ModPrefix {

        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;
        public virtual int minimum_summon => 1;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            if (player.maxMinions > minimum_summon) {
                player.GetDamage(DamageClass.Summon) *= 1f + 0.08f * Power;
                player.maxMinions += -1 * AbsolutePower;
            }
            else {
                player.GetDamage(DamageClass.Summon) *= 1f;
            }

        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            float final_summon = 8f * Power;
            int final_minion = 1 * AbsolutePower;
            var tooltip_final_summon = new TooltipLine(Mod, "PrefixFinalSummon", $"+{final_summon}% summon damage");
            var tooltip_final_minion = new TooltipLine(Mod, "PrefixFinalMinion", $"-{final_minion} summon slots");
            var tooltip_warning = new TooltipLine(Mod, "PrefixLonelyWarning", $"This modifier only works if the player has more than {minimum_summon} minion slots. Else, it does nothing.");

            tooltip_final_minion.IsModifier = true;
            tooltip_final_summon.IsModifier = true;
            tooltip_final_minion.IsModifierBad = true;


            yield return tooltip_final_minion;
            yield return tooltip_final_summon;
            yield return tooltip_warning;

        }
    }

    public class Antagonistic : ModPrefix
    {
        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;

        public override PrefixCategory Category => PrefixCategory.Accessory;
        public int AggroMultiplier => 1;
        public virtual int MinimumPrefixTier => 2;
        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            player.aggro *= 2 * AbsolutePower;
            int AggroMultiplier = Convert.ToInt32(Math.Round((double)player.aggro/1000));

            player.statLifeMax2 += 40 * AbsolutePower * AggroMultiplier;
            player.GetDamage(DamageClass.Generic) *= 1f - 0.1f * AggroMultiplier * Power;
            // Main.NewText(player.aggro);
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            var tooltip_aggro = new TooltipLine(Mod, "PrefixAggroMulti", $"Increases health at the cost of damage based on aggro; Effects are reversed for negative aggro");

            yield return tooltip_aggro;
        }
    }

    public class Aggressive : ModPrefix
    {
        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;

        public virtual int MinimumPrefixTier => 1;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            player.aggro += 400 * AbsolutePower;
            player.lifeRegen += 4 * AbsolutePower;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            var tooltip_aggro = new TooltipLine(Mod, "PrefixAggroMulti", $"Slightly increases aggro and life regeneration");

            yield return tooltip_aggro;
        }
    }

    public class Stealthy : ModPrefix
    {
        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;

        public virtual int MinimumPrefixTier => 1;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            player.aggro += -500 * AbsolutePower;
            player.moveSpeed += 1f - 0.02f * Power;
            player.GetCritChance(DamageClass.Generic) += 1 * AbsolutePower;

        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            var tooltip_aggro = new TooltipLine(Mod, "PrefixAggroMulti", $"Slightly decreases aggro and move speed");

            yield return tooltip_aggro;
        }
    }

    public class Fierce : ModPrefix {

        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;
        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            player.GetDamage(DamageClass.Melee) *= 1f - 0.005f * Power;
            player.GetAttackSpeed(DamageClass.Melee) *= 1f + 0.08f * Power;

        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            float damage = -0.5f * Power;
            float speed = 8f * Power; 
            var tooltip_melee_damage = new TooltipLine(Mod, "PrefixMeleeDamage", $"{damage}% melee damage");
            var tooltip_melee_speed = new TooltipLine(Mod, "PrefixMeleeSpeed", $"+{speed}% melee speed");

            tooltip_melee_damage.IsModifier = true;
            tooltip_melee_damage.IsModifierBad = true;
            tooltip_melee_speed.IsModifier = true;

            yield return tooltip_melee_damage;
            yield return tooltip_melee_speed;
        }
    }

    public class Steady : ModPrefix {

        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;

        //For Tooltip
        public int tooltip_crit_scale = 1;

        public virtual int MinimumPrefixTier => 1;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        // public int ToolTipValue(ref int Variable, int toChange) {
        //     return Variable = toChange;
        // }

        public override void ApplyAccessoryEffects(Player player) {
            int crit_scale = Convert.ToInt32(Math.Round(player.GetCritChance(DamageClass.Generic)/8));
            // ToolTipValue(ref tooltip_crit_scale, crit_scale);

            player.GetDamage(DamageClass.Generic) *= 1f + (float)crit_scale;
            player.GetCritChance(DamageClass.Generic) += -1 * crit_scale;

        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            var tooltip_info = new TooltipLine(Mod, "PrefixInfo", $"Increases damage by an eighth of the players crit rate, then reduces the crit rate");
            // var tooltip_damage_increase = new TooltipLine(Mod, "PrefixDamage", $"+{tooltip_crit_scale}% damage");
            // var tooltip_crit_decrease = new TooltipLine(Mod, "PrefixCrit", $"-{tooltip_crit_scale}% crit chance");

            // tooltip_crit_decrease.IsModifier = true;
            // tooltip_crit_decrease.IsModifierBad = true;
            // tooltip_damage_increase.IsModifier = true;

            // yield return tooltip_damage_increase;
            // yield return tooltip_crit_decrease;
            yield return tooltip_info;
        }
    }

    public class Penetrating : ModPrefix {

        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;

        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            player.GetArmorPenetration(DamageClass.Generic) += 3;
            player.GetArmorPenetration(DamageClass.Generic) = Convert.ToInt32(player.GetArmorPenetration(DamageClass.Generic) * 1.2);

        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            int piercing = 3;
            var tooltip_pierce = new TooltipLine(Mod, "PrefixPierce", $"+{piercing} armor penetration");
            var tooltip_pierce_scale = new TooltipLine(Mod, "PrefixPierceScale", $"increases the effectiveness of armor penetration");

            tooltip_pierce.IsModifier = true;

            yield return tooltip_pierce;
            yield return tooltip_pierce_scale;
        }
    }

    public class Swift : ModPrefix {

        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;

        public virtual int MinimumPrefixTier => 1;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            player.moveSpeed *= 1f + 0.15f * Power;

            float moveSpeed_factor = (player.moveSpeed / 2) + 1;
            player.GetDamage(DamageClass.Generic) *= 1f + 0.05f * moveSpeed_factor * AbsolutePower;

        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            float move_speed = 15f * Power;
            var tooltip_movespeed = new TooltipLine(Mod, "PrefixMovespeed", $"+{move_speed}% movement speed");
            var tooltip_movespeed_scale = new TooltipLine(Mod, "PrefixMovementScale", $"increases damage based off movement speed");

            tooltip_movespeed.IsModifier = true;

            yield return tooltip_movespeed;
            yield return tooltip_movespeed_scale;
        }
    }

    public class Slothful : ModPrefix {

        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;

        public virtual int MinimumPrefixTier => 0;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            player.statManaMax2 += 20 * AbsolutePower;
            player.manaCost *= 1f - 0.1f * Power;
            player.GetDamage(DamageClass.Magic) *= 1f - 0.02f * Power;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            int final_maxmana_prefix = 20 * AbsolutePower;
            float final_damage = 2f * Power;
            float final_manacost = 1f * Power;
            var tooltip_manacost = new TooltipLine(Mod, "PrefixManaCost", $"-{final_manacost}% mana cost per use");
            var tooltip_damage = new TooltipLine(Mod, "PrefixMagicDamage", $"-{final_damage}% magic damage");
            var tooltip_maxmana = new TooltipLine(Mod, "PrefixMaxMana", $"+{final_maxmana_prefix} max mana");

            tooltip_manacost.IsModifier = true;
            tooltip_damage.IsModifier = true;
            tooltip_damage.IsModifierBad = true;
            tooltip_maxmana.IsModifier = true;

            yield return tooltip_manacost;
            yield return tooltip_damage;
            yield return tooltip_maxmana;
        }
    }

    public class Ambulant : ModPrefix {

        public virtual float Power => 1f;
        public virtual int AbsolutePower => 1;
        public virtual int RollPower => 1;

        public virtual int MinimumPrefixTier => 2;

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item) {
            return 1f * RollPower;
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

        public override void ApplyAccessoryEffects(Player player) {
            player.moveSpeed *= 1f + 0.3f * Power;

        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {
            float move_speed = 30f * Power;
            var tooltip_movespeed = new TooltipLine(Mod, "PrefixMovespeed", $"+{move_speed}% movement speed");
            var tooltip_movehelp = new TooltipLine(Mod, "PrefixMovehelp", $"you go zoom");

            tooltip_movespeed.IsModifier = true;
            tooltip_movehelp.IsModifier = true;

            yield return tooltip_movespeed;
            yield return tooltip_movehelp;
        }
    }
}