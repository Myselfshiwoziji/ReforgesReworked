using Terraria;
using Terraria.GameContent.ObjectInteractions;
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
			Item.damage = 100; // The damage for projectiles isn't actually 12, it actually is the damage combined with the projectile and the item together.
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 10;
			Item.consumable = true; 
			Item.knockBack = 5f;
			Item.value = 10;
			Item.rare = ItemRarityID.Red;
			Item.shoot = ModContent.ProjectileType<Items.AtelierLogicBullet>(); // The projectile that weapons fire when using this item as ammunition.
			Item.shootSpeed = 100f; // The speed of the projectile. This value equivalent to Silver Bullet since ExampleBullet's Projectile.extraUpdates is 1.
			Item.ammo = AmmoID.Bullet; // The ammo class this ammo belongs to.
		}

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.EmptyBullet);
            recipe.AddIngredient(ItemID.PlatinumCoin, 5);
            recipe.AddTile(TileID.Hellforge);
            recipe.Register();
        }

    }
}