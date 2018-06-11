using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.NPCs.Bosses
{ 
	
	[AutoloadBossHead]
    public class BoD : ModNPC
    {
       
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brain of Darkness"); 
            Main.npcFrameCount[npc.type] = 5;
        }   

		public override void SetDefaults()
		{
            npc.aiStyle = 5;  //5 is the flying AI
            npc.lifeMax = 3480;   //boss life
            npc.damage = 100;  //boss damage
            npc.defense = 10;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 100;
            npc.height = 100;
            animationType = NPCID.BrainofCthulhu;   //this boss will behavior like the DemonEye
           //boss frame/animation 
            npc.npcSlots = 4f;
            npc.boss = true;  
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath10;
            npc.buffImmune[24] = true;
            music = MusicID.Boss2;
            npc.netAlways = true;
            bossBag = mod.ItemType("BoDBag");
        }
  public override void BossLoot(ref string name, ref int potionType)
        {
			if (Main.expertMode)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BoDBag"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
			}
            potionType = ItemID.LesserHealingPotion;   //boss drops
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkChunk"));
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);  //boss life scale in expertmode
            npc.damage = (int)(npc.damage * 0.6f);  //boss damage increase in expermode
        }
        
        public override void AI()
        {
            npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;

            npc.ai[1]++;
            if (npc.ai[1] >= 40)  // 230 is projectile fire rate
            {
                float Speed = 20f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 50;  //projectile damage
                int type = mod.ProjectileType("ChaosOrb");  //put your projectile
                Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 0;
            }


            if (npc.ai[1] >= 40)  // 230 is projectile fire rate
                {
                    float Speed = 20f;  //projectile speed
                    Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                    int damage = 50;  //projectile damage
                    int type = mod.ProjectileType("SpikedChaosBall");  //put your projectile
                    Main.PlaySound(24, (int)npc.position.X, (int)npc.position.Y, 16);
                    float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                    int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                    npc.ai[1] = 0;
                } //when the boss has less than 70 health he will do the charge attack
                
             if (npc.ai[0] >= 1000)  //Npc spown rate

            {
                NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("DarkCreeper"));  //NPC name
            }
            npc.ai[1] += 0;
            if (npc.life <= 2000) 
             if (npc.ai[1] >= 20)  // 230 is projectile fire rate
            {
                float Speed = 20f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 50;  //projectile damage
                int type = mod.ProjectileType("ChaosOrb");  //put your projectile
                Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 0;
            } //when the boss has less than 70 health he will do the charge attack

            if (npc.life <= 2000) 
             if (npc.ai[1] >= 20)  // 230 is projectile fire rate
            {
                float Speed = 20f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 50;  //projectile damage
                int type = mod.ProjectileType("SpikedChaosOrb");  //put your projectile
                Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 0;
            } //when the boss has less than 70 health he will do the charge attack
                npc.ai[2]++;      
            if (npc.life <=2000)  
            {
                if (npc.ai[0] >= 250)  //Npc spown rate

                {
                 NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("DarkCreeper"));  //NPC name
                }

                 if (npc.ai[2] >= 20)
                {
                     npc.velocity.X *= 0.98f;
                    npc.velocity.Y *= 0.98f;
                    Vector2 vector8 = new Vector2(npc.position.X + (npc.width * 0.5f), npc.position.Y + (npc.height * 0.5f));
                    {
                    float rotation = (float)Math.Atan2((vector8.Y) - (Main.player[npc.target].position.Y + (Main.player[npc.target].height * 0.5f)), (vector8.X) - (Main.player[npc.target].position.X + (Main.player[npc.target].width * 0.5f)));
                    npc.velocity.X = (float)(Math.Cos(rotation) * 12) * -1;
                    npc.velocity.Y = (float)(Math.Sin(rotation) * 12) * -1;
                    }
                     //Dust
                    npc.ai[0] %= (float)Math.PI * 2f;
                    Vector2 offset = new Vector2((float)Math.Cos(npc.ai[0]), (float)Math.Sin(npc.ai[0]));
                    Main.PlaySound(2, (int)npc.position.X, (int)npc.position.Y, 20);
                    npc.ai[2] = -300;
                    Color color = new Color();
                    Rectangle rectangle = new Rectangle((int)npc.position.X, (int)(npc.position.Y + ((npc.height - npc.width) / 2)), npc.width, npc.width);
                     int count = 30;
                    for (int i = 1; i <= count; i++)
                    {
                    int dust = Dust.NewDust(npc.position, rectangle.Width, rectangle.Height, 119, 97, 97, 255, color, 2.5f);
                    Main.dust[dust].noGravity = false;
                    }
                    return;
                    }//Charge Attack
            if (npc.life <=1000)  
            {
                Main.PlaySound(44, (int)npc.position.X, (int)npc.position.Y, 44);
                if (npc.ai[1] >= 5)  // 230 is projectile fire rate
                {
                    float Speed = 20f;  //projectile speed
                    Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                    int damage = 50;  //projectile damage
                    int type = mod.ProjectileType("ChaosOrb");  //put your projectile
                    Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                    float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                    int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                    npc.ai[1] = 0;
                } //when the boss has less than 70 health he will do the charge attack
                npc.ai[2]++;     
            }//Charge Attack
            if (npc.life <=1000)  
            {
                Main.PlaySound(44, (int)npc.position.X, (int)npc.position.Y, 44);
                if (npc.ai[1] >= 5)  // 230 is projectile fire rate
                {
                    float Speed = 20f;  //projectile speed
                    Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                    int damage = 50;  //projectile damage
                    int type = mod.ProjectileType("SpikedChaosBall");  //put your projectile
                    Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                    float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                    int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                    npc.ai[1] = 0;
                } //when the boss has less than 70 health he will do the charge attack
                npc.ai[2]++;     
            }//Charge Attack



             if (npc.life <=750)  
            {
                if (npc.ai[0] >= 100)  //Npc spown rat
                {
                 NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("DarkCreeper"));  //NPC name
                } 
            }//Charge Attack
            if (npc.life <=750)
            {
                if (npc.ai[1] >= 1)  // 230 is projectile fire rate
                {
                    float Speed = 20f;  //projectile speed
                    Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                    int damage = 50;  //projectile damage
                    int type = mod.ProjectileType("SpikedChaosBall");  //put your projectile
                    Main.PlaySound(24, (int)npc.position.X, (int)npc.position.Y, 16);
                    float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                    int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                    npc.ai[1] = 0;
                } //when the boss has less than 70 health he will do the charge attack
            if (npc.life <=750)
            {
                if (npc.ai[2] >= 20)
                {
                     npc.velocity.X *= 2f;
                    npc.velocity.Y *= 2f;
                    Vector2 vector8 = new Vector2(npc.position.X + (npc.width * 1f), npc.position.Y + (npc.height * 1f));
                    {
                    float rotation = (float)Math.Atan2((vector8.Y) - (Main.player[npc.target].position.Y + (Main.player[npc.target].height * 1f)), (vector8.X) - (Main.player[npc.target].position.X + (Main.player[npc.target].width * 1f)));
                    npc.velocity.X = (float)(Math.Cos(rotation) * 24) * -1;
                    npc.velocity.Y = (float)(Math.Sin(rotation) * 24) * -1;
                    }
                     //Dust
                    npc.ai[0] %= (float)Math.PI * 4f;
                    Vector2 offset = new Vector2((float)Math.Cos(npc.ai[0]), (float)Math.Sin(npc.ai[0]));
                    Main.PlaySound(44, (int)npc.position.X, (int)npc.position.Y, 40);
                    npc.ai[2] = -150;
                    Color color = new Color();
                    Rectangle rectangle = new Rectangle((int)npc.position.X, (int)(npc.position.Y + ((npc.height - npc.width) / 4)), npc.width, npc.width);
                     int count = 60;
                    for (int i = 2; i <= count; i++)
                    {
                    int dust = Dust.NewDust(npc.position, rectangle.Width, rectangle.Height, 12, 0, 0, 200, color, 5f);
                    Main.dust[dust].noGravity = false;
                    }
                    return;
                }
            }
        }
    }
} }} 