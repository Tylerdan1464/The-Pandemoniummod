using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System.Linq;
using ThePandemoniummod.Tiles;
 
 
namespace ThePandemoniummod
{
    public class Ore2 : ModWorld
    {
 
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (genIndex == -1)
            {
                return;
            }
            tasks.Insert(genIndex + 1, new PassLegacy("BitterShade", delegate (GenerationProgress progress)
            {
                progress.Message = "BitterShade Progress";
                for (int i = 0; i < Main.maxTilesX / 250; i++)       //900 is how many biomes. the bigger is the number = less biomes
                {
                    int X = WorldGen.genRand.Next(1, Main.maxTilesX - 300);
                    int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer - 0, Main.maxTilesY - 0);
                    int TileType = mod.TileType("BitterShade");     //this is the tile u want to use for the biome , if u want to use a vanilla tile then its int TileType = 56; 56 is obsidian block
                    WorldGen.TileRunner(X, Y, 45, WorldGen.genRand.Next(100, 200), TileType, false, 0f, 0f, true, true);  //350 is how big is the biome     100, 200 this changes how random it looks.

                }
 
            }));
        }
    }
}