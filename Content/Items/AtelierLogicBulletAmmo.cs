using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ReforgesReworked.Content.Config;

namespace ReforgesReworked.Content.Items {
    public class AtelierLogicBulletAmmo : ModItem {
		public override bool IsLoadingEnabled(Mod mod) {
            return ModContent.GetInstance<DebugConfig>().Debug;
        }
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 10;
		}

		public override void SetDefaults() {
			Item.damage = 250;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 1000;
			Item.consumable = true; 
			Item.knockBack = 5f;
			Item.value = 10;
			Item.rare = ItemRarityID.Red;
			Item.shoot = ModContent.ProjectileType<Items.AtelierLogicBullet>(); 
			Item.shootSpeed = 40f;
			Item.ammo = AmmoID.Bullet;
		}

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.EmptyBullet);
            recipe.AddIngredient(ItemID.PlatinumCoin, 5);
            recipe.AddIngredient(ItemID.HighVelocityBullet, 50);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.Register();
        }

    }
}