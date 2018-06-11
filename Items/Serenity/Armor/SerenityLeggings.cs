using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items.Serenity.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class SerenityLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Serenity Boots");
			Tooltip.SetDefault("Greatly increased movement speed and immunity to chilled"
			+ "\nIncreased magic and ranged damage"
			+ "\n+30 Mana");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.8f;
			player.rangedDamage += 0.8f;
			player.moveSpeed += 0.50f;
			player.statManaMax2 += 30;
			player.buffImmune[BuffID.Chilled] = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SerenityBar", 18);
			recipe.AddIngredient(null, "LifeForce", 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}