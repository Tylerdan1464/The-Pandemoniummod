using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class ShieldofBiter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Shield of Biter");
			Tooltip.SetDefault("The Shield makes your skin tough..."
				+ "\nIncreased Defense");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 8;
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