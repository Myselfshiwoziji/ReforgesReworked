using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ReforgesReworked.Content.Config;


namespace ReforgesReworked.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class TestSword : ModItem
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
	}
}
