using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items
{
	public class BitterShadeBars : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BitterShade Bar"); 
			Tooltip.SetDefault("'Stings your fingers'");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
		}

		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BitterShadeOre", 3);
			recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SerenityBar");
			recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}