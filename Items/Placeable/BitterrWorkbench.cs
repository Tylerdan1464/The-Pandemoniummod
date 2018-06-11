using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items.Placeable
{
	public class BitterrWorkbench : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Goes well with cactus'");
		}
		
		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("BitterWorkbench");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BitterWood", 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}