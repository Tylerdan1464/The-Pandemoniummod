using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items.Placeable
{
	public class BitterBed : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Not very comfortable sleeping on wood, but it works.");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 20;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 2000;
			item.createTile = mod.TileType("BitterrBed");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BitterWood", 10);
			recipe.AddTile(null, "BitterWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}