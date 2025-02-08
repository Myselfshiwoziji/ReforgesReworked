using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using ReforgesReworked.Content.Dusts;
using ReforgesReworked.Content.Config;
using System;



namespace ReforgesReworked.Content.Items
{ 
	public class ShiAssocKatana : ModItem
	{

		public override bool IsLoadingEnabled(Mod mod) {

            return ModContent.GetInstance<DebugConfig>().Debug;
        }

		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.ReforgesReworked.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 500;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(silver: 1);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtiestBlock, 1000);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<Dusts.ShiDust>()); // Doesn't work
			// if (Main.rand.NextBool(3)) {
			// 	// Emit dusts when the sword is swung
			// 	Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<Dusts.ShiDust>());
			// }
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) {
			// 60 frames = 1 second
			target.AddBuff(ModContent.BuffType<ShiDebuff>(), 600);
		}
	}
}
