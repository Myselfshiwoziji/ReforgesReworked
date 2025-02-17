using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using ReforgesReworked.Content.Config;

namespace ReforgesReworked.Content.Items {
    public class AtelierLogicBullet : ModProjectile {
		public override bool IsLoadingEnabled(Mod mod) {

            return ModContent.GetInstance<DebugConfig>().Debug;
        }
		public override void SetStaticDefaults() {
			ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5; // The length of old position to be recorded
			ProjectileID.Sets.TrailingMode[Projectile.type] = 0; // The recording mode
        }

		public override void SetDefaults() {
			Projectile.width = 8; 
			Projectile.height = 10; 
			Projectile.aiStyle = 1; 
			Projectile.friendly = true; 
			Projectile.hostile = false; 
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.penetrate = 50; 
			Projectile.timeLeft = 600; 
			Projectile.light = 1.5f; // How much light emit around the projectile
			Projectile.ignoreWater = true; 
			Projectile.tileCollide = true; 
            Projectile.extraUpdates = 2;

			AIType = ProjectileID.Bullet;
		}

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Projectile.Kill();
            return false;
        }
		public override bool PreDraw(ref Color lightColor) {

			Texture2D texture = TextureAssets.Projectile[Type].Value;

			Vector2 drawOrigin = new Vector2(texture.Width * 20f, Projectile.height * 5f);
			for (int k = Projectile.oldPos.Length - 1; k > 0; k--) {
				Vector2 drawPos = (Projectile.oldPos[k] - Main.screenPosition) + drawOrigin + new Vector2(0f, Projectile.gfxOffY);
				Color color = Projectile.GetAlpha(lightColor) * ((Projectile.oldPos.Length - k) / (float)Projectile.oldPos.Length);
				Main.EntitySpriteDraw(texture, drawPos, null, color, Projectile.rotation, drawOrigin, Projectile.scale, SpriteEffects.None, 0);
			}

			return true;
		}

		public override void OnKill(int timeLeft) {
			Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
			SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
		}
    }
}