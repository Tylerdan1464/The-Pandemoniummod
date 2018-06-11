using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.NPCs
{
	public class TrueMeteorHead : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Meteor Head");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.EyeofCthulhu];
		}

		public override void SetDefaults()
		{
			npc.width = 50;
			npc.height = 51;
			npc.damage = 25;
			npc.defense = 6;
			npc.lifeMax = 100;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 5;
			npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
			aiType = NPCID.EyeofCthulhu;
			animationType = NPCID.MeteorHead;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return Main.dayTime && Main.tile[(spawnInfo.spawnTileX), (spawnInfo.spawnTileY)].type == mod.TileType("BitterBlock") ? 100f : 0f;
		}

		 public override void NPCLoot()  //Npc drop
        {
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BitterFood"), 2); //Item spawn
            }

        }
	}
}
