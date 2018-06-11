using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class BrittleShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brittle Shield");
			Tooltip.SetDefault("The Shield makes you feel strong..."
				+ "\nIncreased Stats after killing the Eye of Cthulhu");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 2;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if (NPC.downedBoss1)  //so after the EoC is killed
			{
				player.meleeDamage += .19f;
				player.thrownDamage += .19f;
				player.rangedDamage += .19f;
				player.magicDamage += .19f;
				player.minionDamage += .19f;
				player.endurance = 1f - 0.1f * (1f - player.endurance);
			}
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