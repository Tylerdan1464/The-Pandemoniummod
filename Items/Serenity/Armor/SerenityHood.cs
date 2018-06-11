using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items.Serenity.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SerenityHood : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Serenity Hood");
			Tooltip.SetDefault("Boosts archery and shows enemies"
			+ "\n+40 Mana"
			+ "\nIncreased magic and ranged damage"
			+ "\nEffects only active with full set");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("SerenityBreastplate") && legs.type == mod.ItemType("SerenityLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.magicDamage += 0.8f;
			player.rangedDamage += 0.8f;
			player.moveSpeed += 0.50f;
			player.statManaMax2 += 40;
			player.AddBuff(BuffID.Archery, 2);
			player.AddBuff(BuffID.Hunter, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SerenityBar", 10);
			recipe.AddIngredient(null, "LifeForce", 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}