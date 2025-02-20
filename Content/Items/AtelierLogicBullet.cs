using Microsoft.Xna.Framework;
// using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Audio;
// using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using ReforgesReworked.Content.Config;
// using Microsoft.Build.Evaluation;
// using System.Numerics;

namespace ReforgesReworked.Content.Items {
    public class AtelierLogicBullet : ModProjectile {
		public override bool IsLoadingEnabled(Mod mod) {

            return ModContent.GetInstance<DebugConfig>().Debug;
        }
		public override void SetStaticDefaults() {
			// ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5; 
			// ProjectileID.Sets.TrailingMode[Projectile.type] = 0;
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
			Projectile.light = 3f; // amount of light emitted
			Projectile.ignoreWater = true; 
			Projectile.tileCollide = true; 
            Projectile.extraUpdates = 3;

			AIType = ProjectileID.Bullet;
		}

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            if (Projectile.penetrate <= 0) {
                Projectile.Kill();
            }
            else {
                Projectile.penetrate = (int)Math.Floor((double)Projectile.penetrate/2);
            }

            if (Math.Abs(Projectile.velocity.X - oldVelocity.X) > float.Epsilon) {
                Projectile.velocity.X = 3 * oldVelocity.X;
            }

            if (Math.Abs(Projectile.velocity.Y - oldVelocity.Y) > float.Epsilon) {
                Projectile.velocity.Y = 3 * oldVelocity.Y;
            }
            return false;
        }

        // public override bool PreDraw(ref Color lightColor) {

        // 	Texture2D texture = TextureAssets.Projectile[Type].Value;

        // 	Vector2 drawOrigin = new Vector2(texture.Width * 0.5f, Projectile.height * 0.5f);
        // 	for (int k = Projectile.oldPos.Length + 1; k > 0; k--) {
        // 		Vector2 drawPos = (Projectile.oldPos[k] - Main.screenPosition) + drawOrigin + new Vector2(0f, Projectile.gfxOffY);
        // 		Color color = Projectile.GetAlpha(lightColor) * ((Projectile.oldPos.Length - k) / (float)Projectile.oldPos.Length);
        // 		Main.EntitySpriteDraw(texture, drawPos, null, color, Projectile.rotation, drawOrigin, Projectile.scale, SpriteEffects.None, 0);
        // 	}

        // 	return true;
        // }

        public override void OnKill(int timeLeft) {
			Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
			SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
		}
    }
}