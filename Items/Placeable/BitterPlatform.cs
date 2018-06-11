using Terraria.ModLoader;

namespace ThePandemoniummod.Items.Placeable
{
	public class BitterPlatform : ModItem
	{

		public override void SetDefaults()
		{
			item.width = 8;
			item.height = 10;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("BitterrPlatform");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BitterWood");
			recipe.SetResult(this, 2);
			recipe.AddTile(null, "BitterWorkbench");
			recipe.AddRecipe();
		}
	}
}