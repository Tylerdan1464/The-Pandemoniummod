using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ThePandemoniummod.Items
{
	public class MeteorLaser : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Shoot a laser beam that can eliminate anything...");
		}

		public override void SetDefaults()
		{
			item.damage = 35;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 5;
			item.rare = 5;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = 5;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("MeteorLaser");
			item.value = Item.sellPrice(silver: 3);
		}

	}
}
