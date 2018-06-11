using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items
{
	public class Adhesive : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adhesive"); 
			Tooltip.SetDefault("'Very Sticky'");
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