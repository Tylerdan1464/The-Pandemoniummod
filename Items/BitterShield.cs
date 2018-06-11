using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class BitterShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bitter Shield");
			Tooltip.SetDefault("The Shield seems to connect to you..."
				+ "\nGreatly Increased Life Regen");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 2;
			item.lifeRegen = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BitterShadeBars", 12);
			recipe.AddIngredient(null, "BS", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}