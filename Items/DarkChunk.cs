using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items
{
	public class DarkChunk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Chunk"); 
			Tooltip.SetDefault("It provokes darkness to the touch.");
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