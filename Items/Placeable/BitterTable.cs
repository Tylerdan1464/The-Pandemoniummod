using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items.Placeable
{
	public class BitterTable : ModItem
	{

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 30;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("BitterrTable");
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