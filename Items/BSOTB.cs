using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class BSOTB : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bitter Brittle Shield of the Biter");
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
			item.defense = 8;
			item.lifeRegen = 10;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if (NPC.downedBoss1)  //so after the EoC is killed
			{
				player.AddBuff(BuffID.Swiftness, 5);
				player.meleeDamage += 0.8f;
				player.thrownDamage += 0.8f;
				player.rangedDamage += 0.8f;
				player.magicDamage += 0.8f;
				player.minionDamage += 0.8f;
				player.endurance = 1f - 0.1f * (1f - player.endurance);
			}
		}

		


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ShieldofBiter");
			recipe.AddIngredient(null, "BitterShield");
			recipe.AddIngredient(null, "BrittleShield");
			recipe.AddIngredient(null, "BitterShadeBars", 12);
			recipe.AddIngredient(null, "BS", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}