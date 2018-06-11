using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items.Serenity.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SerenityHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Serenity Helm");
			Tooltip.SetDefault("The wearer can breathe underwater, but cannot breathe air"
			+ "\nEffects only active with full set");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 4;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("SerenityBreastplate") && legs.type == mod.ItemType("SerenityLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.AddBuff(BuffID.Gills, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "LifeForce", 8);
			recipe.AddIngredient(null, "SerenityBar", 14);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}