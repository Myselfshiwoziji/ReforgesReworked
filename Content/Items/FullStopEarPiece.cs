using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ReforgesReworked.Content.Config;

namespace ReforgesReworked.Content.Items {
    public class FullStopEarPiece : ModItem {
		public override bool IsLoadingEnabled(Mod mod) {

            return ModContent.GetInstance<DebugConfig>().Debug;
        }

        // public bool CheckForBullets(Player player) {
        //     for (int i = 0; i < player.inventory.Length; i++) {
        //         if (player.inventory[i].useAmmo == 0) {
        //             return false;
        //         }
        //     }
        //     return true;
        // }

        public static readonly int RangedSpeedBonus = 50;
        public static readonly int RangedDamageBonus = 12;
        // public static readonly int MeleeDamageBonus = 12;
        public static readonly int ArmorPenetrate = 5;

        public override void SetDefaults() {
			Item.width = 40;
			Item.height = 40;
			Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
            Item.CloneDefaults(ItemID.Radar);
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Ranged) += (float)RangedDamageBonus / 100f;
            player.GetAttackSpeed(DamageClass.Ranged) += (float)RangedSpeedBonus / 100f;
            player.GetArmorPenetration(DamageClass.Ranged) += (float)ArmorPenetrate;

        }

        public override void UpdateInfoAccessory(Player player)
        {
            // player.GetAttackSpeed(DamageClass.Ranged) = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.TitaniumBar, 15);
            recipe.AddIngredient(ItemID.DarkShard, 1);
            recipe.AddTile(TileID.AdamantiteForge);

            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.AdamantiteBar, 12);
            recipe2.AddIngredient(ItemID.DarkShard, 1);
            recipe2.AddTile(TileID.AdamantiteForge);
        }

    }
}