using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items.Serenity
{
	[AutoloadEquip(EquipType.Shield)]
	public class HermesShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hermes Shield");
			Tooltip.SetDefault("The Shield makes you faster..."
				+ "\nGreatly Increased Movement Speed");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 1;
		}

		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.8f;
			player.rangedDamage += 0.8f;
			player.moveSpeed += 2;
			player.statManaMax2 += 30;
			player.AddBuff(BuffID.ManaRegeneration, 2);
			player.AddBuff(BuffID.MagicPower, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BitterShadeBars", 12);
			recipe.AddIngredient(null, "BS", 10);
			recipe.AddIngredient(null, "SerenityBar", 12);
			recipe.AddIngredient(null, "LifeForce", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}