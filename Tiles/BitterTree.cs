using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace ThePandemoniummod.Tiles
{
	public class BitterTree : ModTree
	{
		private Mod mod
		{
			get
			{
				return ModLoader.GetMod("ThePandemoniummod");
			}
		}

		public override int CreateDust()
		{
			return mod.DustType("Sparkle");
		}

		public override int DropWood()
		{
			return mod.ItemType("BitterBlock");
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/BitterTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
		{
			return mod.GetTexture("Tiles/BitterTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
		{
			return mod.GetTexture("Tiles/BitterTree_Branches");
		}
	}
}