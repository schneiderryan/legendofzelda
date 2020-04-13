using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class RoomLoader
    {
        private RoomParser parser;
        private LegendOfZelda game;
        private Random random = new Random();

        public RoomLoader(string level, LegendOfZelda game)
        {
            this.parser = new RoomParser();
            parser.Parse(level);
            this.game = game;
        }

        public int RoomNumber() => parser.RoomNumber;

        public ISprite LoadBackground()
        {
            ISprite background;
            background = RoomSpriteFactory.Instance.CreateRooms(game.xRoom, game.yRoom);
            return background;
        }

        public ISet<IEnemy> LoadEnemies(IDictionary<string, IDoor> doors)
        {
            ISet<IEnemy> enemies = new HashSet<IEnemy>();
            IDictionary<Vector2, string> enemyInfo = parser.Enemies;
            foreach (KeyValuePair<Vector2, String> entry in enemyInfo)
            {
                IEnemy enemy;
                if (entry.Value.Equals("Aquamentus"))
                {
                    enemy = new Aquamentus(doors, game.ProjectileManager, game.link);
                }
                else if (entry.Value.Equals("Gel"))
                {
                    enemy = new Gel();
                }
                else if (entry.Value.Equals("Goriya"))
                {
                    enemy = new Goriya(this.game.ProjectileManager);
                }
                else if (entry.Value.Equals("Keese"))
                {
                    enemy = new Keese();
                }
                else if (entry.Value.Equals("LFWallmaster"))
                {
                    enemy = new LFWallmaster();
                }
                else if (entry.Value.Equals("RFWallmaster"))
                {
                    enemy = new RFWallmaster();
                }
                else if (entry.Value.Equals("Stalfo"))
                {
                    enemy = new Stalfo();
                    if (enemies.Count == 1 && (RoomNumber() == 2 || RoomNumber() == 12))
                    {
                        enemy.Item = new Key();
                    }
                }
                else if (entry.Value.Equals("Snake"))
                {
                    enemy = new Snake(game);
                }
                else if (entry.Value.Equals("Dodongo"))
                {
                    enemy = new Dodongo();
                }
                else if (entry.Value.Equals("Fire"))
                {
                    enemy = new Fire(game);
                }
                else if (entry.Value.Equals("Zol"))
                {
                    enemy = new Zol();
                }
                else //trap
                {
                    enemy = new Trap(game);
                }
                enemy.X = (int)entry.Key.X;
                enemy.Y = (int)entry.Key.Y + 120;
                enemies.Add(enemy);
                int rand = random.Next(0, 22);
                if (enemy.Item == null && !(enemy is Keese || enemy is Aquamentus))
                {
                    if (0 <= rand && rand <= 8)
                    {
                        enemy.Item = new Rupee();
                    }
                    else if (9 <= rand && rand <= 12)
                    {
                        enemy.Item = new Heart();
                    }
                    else if (rand == 14)
                    {
                        enemy.Item = new Clock(game);
                    }
                    else if (rand == 15)
                    {
                        enemy.Item = new Fairy();
                    }
                    else if (rand == 20)
                    {
                        enemy.Item = new BlueRupee();
                    }
                    else if (16 <= rand && rand <= 26 && enemy is Goriya)
                    {
                        enemy.Item = new Bomb();
                    }

                }
            }
        
            return enemies;
        }

        public IList<IItem> LoadItems()
        {
            List<IItem> items = new List<IItem>();
            IDictionary<Vector2, string> itemInfo = parser.Items;
            foreach (KeyValuePair<Vector2, String> entry in itemInfo)
            {
                IItem item;
                if (entry.Value.Equals("Arrow"))
                {
                    item = new Arrow();
                }
                else if (entry.Value.Equals("BlueRupee"))
                {
                    item = new BlueRupee();
                }
                else if (entry.Value.Equals("Bomb"))
                {
                    item = new Bomb();
                }
                else if (entry.Value.Equals("Bow"))
                {
                    item = new Bow();
                }
                else if (entry.Value.Equals("Boomerang"))
                {
                    item = new Boomerang();
                }
                else if (entry.Value.Equals("Clock"))
                {
                    item = new Clock(game);
                }
                else if (entry.Value.Equals("Compass"))
                {
                    item = new Compass();
                }
                else if (entry.Value.Equals("Fairy"))
                {
                    item = new Fairy();
                }
                else if (entry.Value.Equals("Heart"))
                {
                    item = new Heart();
                }
                else if (entry.Value.Equals("HeartContainer"))
                {
                    item = new HeartContainer();
                }
                else if (entry.Value.Equals("Key"))
                {
                    item = new Key();
                }
                else if (entry.Value.Equals("Map"))
                {
                    item = new Map();
                }
                else if (entry.Value.Equals("Rupee"))
                {
                    item = new Rupee();
                }
                else if (entry.Value.Equals("TriforceShard"))
                {
                    item = new TriforceShard(game);
                }
                else if (entry.Value.Equals("RedRing"))
                {
                    item = new RedRing(game);
                }
                else //wood sword
                {
                    item = new WoodSword();
                }
                item.X = (int)entry.Key.X;
                item.Y = 120+(int)entry.Key.Y;
                items.Add(item);
            }
            return items;
        }

        public IList<IBlock> LoadBlocks(IDictionary<string, IDoor> doors)
        {
            IList<IBlock> blocks = new List<IBlock>();
            IDictionary<Vector2, string> blockInfo = parser.Blocks;
            foreach (KeyValuePair<Vector2, String> entry in blockInfo)
            {
                IBlock block = null;
                if (entry.Value.Equals("Block")) 
                {
                    block = new InvisibleBlock();
                }
                else if (entry.Value.Equals("StairUp"))
                {
                    block = new Stairs(Stairs.StairDirection.Up);
                }
                else if (entry.Value.Equals("StairDown"))
                {
                    block = new Stairs(Stairs.StairDirection.Down);
                }
                else if (entry.Value.Equals("MoveableBlockVertical"))
                {
                    block = new MoveableBlockVertical(doors);
                }
                else if (entry.Value.Equals("MoveableBlockLeft"))
                {
                    block = new MoveableBlockLeft(doors);
                }

                if (block != null)
                {
                    block.X = (int)entry.Key.X;
                    block.Y = 120+(int)entry.Key.Y;
                    blocks.Add(block);
                }
            }
            return blocks;
        }

        public Dictionary<String, IDoor> LoadDoors()
        {
            Dictionary<String, IDoor> doors = new Dictionary<String, IDoor>();
            IDictionary<string, string> doorInfo = parser.Doors;

            foreach (KeyValuePair<String, String> entry in doorInfo)
            {
                IDoor door;
                if (entry.Key.Equals("left"))
                {
                    if (entry.Value.Equals("Wall"))
                    {
                        door = new LeftWall();
                    }
                    else if (entry.Value.Equals("Open"))
                    {
                        door = new LeftOpen();
                    }
                    else if (entry.Value.Equals("Key"))
                    {
                        door = new LeftKey();
                    }
                    else if (entry.Value.Equals("Other"))
                    {
                        door = new LeftOther();
                    }
                    else
                    {
                        door = new LeftExploded();
                    }
                    door.X = 0;
                    door.Y = 264;
                }
                else if (entry.Key.Equals("right"))
                {
                    if (entry.Value.Equals("Wall"))
                    {
                        door = new RightWall();
                    }
                    else if (entry.Value.Equals("Open"))
                    {
                        door = new RightOpen();
                    }
                    else if (entry.Value.Equals("Key"))
                    {
                        door = new RightKey();
                    }
                    else if (entry.Value.Equals("Other"))
                    {
                        door = new RightOther();
                    }
                    else
                    {
                        door = new RightExploded();
                    }
                    door.X = 448;
                    door.Y = 265;
                }
                else if (entry.Key.Equals("top"))
                {
                    if (entry.Value.Equals("Wall"))
                    {
                        door = new TopWall();
                    }
                    else if (entry.Value.Equals("Open"))
                    {
                        door = new TopOpen();
                    }
                    else if (entry.Value.Equals("Key"))
                    {
                        door = new TopKey();
                    }
                    else if (entry.Value.Equals("Other"))
                    {
                        door = new TopOther();
                    }
                    else
                    {
                        door = new TopExploded();
                    }
                    door.X = 224;
                    door.Y = 120;
                }
                else // bottom
                {
                    if (entry.Value.Equals("Wall"))
                    {
                        door = new BottomWall();
                    }
                    else if (entry.Value.Equals("Open"))
                    {
                        door = new BottomOpen();
                    }
                    else if (entry.Value.Equals("Key"))
                    {
                        door = new BottomKey();
                    }
                    else if (entry.Value.Equals("Other"))
                    {
                        door = new BottomOther();
                    }
                    else
                    {
                        door = new BottomExploded();
                    }
                    door.X = 224;
                    door.Y = 408;
                }

                doors.Add(entry.Key, door);
            }
            return doors;
        }

        public IList<INPC> LoadNPCs()
        {
            IList<INPC> npcs = new List<INPC>();
            IDictionary<Vector2, string> info = parser.NPCs;
            foreach (KeyValuePair<Vector2, String> entry in info)
            {
                INPC npc;
                if (entry.Value.Equals("OldMan"))
                {
                    npc = new OldMan(game);
                }
                else
                {
                    npc = new Merchant();
                }
                npc.X = (int)entry.Key.X;
                npc.Y = 120+(int)entry.Key.Y;
                
                npcs.Add(npc);
            }

            return npcs;
        }

    }
}