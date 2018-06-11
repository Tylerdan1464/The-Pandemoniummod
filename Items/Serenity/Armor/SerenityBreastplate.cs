using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items.Serenity.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class SerenityBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Serenity Chestplate");
			Tooltip.SetDefault("Provides increased magic damage and regeneration"
			+ "\n+30 Mana"
			+ "\nIncreased magic and ranged damage");
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
			player.AddBuff(BuffID.ManaRegeneration, 2);
			player.AddBuff(BuffID.MagicPower, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SerenityBar", 20);
			recipe.AddIngredient(null, "LifeForce", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}