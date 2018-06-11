using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.NPCs
{
	public class Brittlet : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brittlet");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 14;
			npc.defense = 6;
			npc.lifeMax = 100;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return Main.dayTime && Main.tile[(spawnInfo.spawnTileX), (spawnInfo.spawnTileY)].type == mod.TileType("BitterBlock") ? 100f : 0f;
		}

		public override void NPCLoot()  //Npc drop
        {
            {
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BS"), 1); //Item spawn
            }
        }
	}
}
