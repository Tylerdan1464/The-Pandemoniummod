using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class ExampleBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("BitterShade Chestplate");
			Tooltip.SetDefault("+20 Mana and Health"
			+ "\nImmunity To Webbed"
			+ "\nEffects only active with full set");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeDamage += 0.8f;
			player.thrownDamage += 0.8f;
			player.buffImmune[BuffID.Webbed] = true;
			player.statLifeMax2 += 20;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BitterShadeBars", 20);
			recipe.AddIngredient(null, "BS", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}