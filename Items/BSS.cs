using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ThePandemoniummod.Projectiles;

namespace ThePandemoniummod.Items
{
	public class BSS : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BitterShade Sword");
		}
		public override void SetDefaults()
		{
			item.damage = 	7;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 16f;
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useStyle = 3;
				item.damage = 7;
				item.shoot = mod.ProjectileType("SirenLure");
			}
			else
			{
				item.useStyle = 1;
				item.useTime = 10;
				item.useAnimation = 10;
				item.damage = 7;
				item.shoot = 0;
			}
			return base.CanUseItem(player);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BitterShadeBars", 8);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
