using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items
{
	public class SerenityBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Serenity Bar"); 
			Tooltip.SetDefault("You feel... bliss."); 
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
			recipe.AddIngredient(null, "SerenityOre", 3);
			recipe.AddIngredient(null, "LifeForce", 5);
			recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BitterShadeBars");
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
	}
}