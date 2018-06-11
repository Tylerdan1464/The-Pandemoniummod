using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class ExampleHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BitterShade Helm");
			Tooltip.SetDefault("Melee damage increased by 8% and Health increased by 20"
			+ "\nProvides the Spelunker effect"
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
			return body.type == mod.ItemType("ExampleBreastplate") && legs.type == mod.ItemType("ExampleLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.meleeDamage += 0.8f;
			player.statManaMax2 += 20;
			player.statLifeMax2 += 20;
			player.AddBuff(BuffID.Spelunker, 2);
			player.thrownDamage += 0.8f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BS", 8);
			recipe.AddIngredient(null, "BitterShadeBars", 14);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}