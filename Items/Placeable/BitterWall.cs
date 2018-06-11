using Terraria.ModLoader;

namespace ThePandemoniummod.Items.Placeable
{
	public class BitterWall : ModItem
	{

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createWall = mod.WallType("BitterrWall");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BitterWood");
			recipe.AddTile(null, "BitterWorkbench");
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}