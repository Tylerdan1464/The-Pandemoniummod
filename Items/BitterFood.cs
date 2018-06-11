using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items
{
	public class BitterFood : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is... not very appetising.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
		}


	}
}
