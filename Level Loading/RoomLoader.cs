using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class RoomLoader
    {
        private RoomParser parser;
        private LegendOfZelda game;

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
            int roomNumber = parser.RoomNumber;
            if (roomNumber == 0)
            {
                background = RoomSpriteFactory.Instance.CreateRoom0();
            }
            else if (roomNumber == 1)
            {
                background = RoomSpriteFactory.Instance.CreateRoom1();
            }
            else if (roomNumber == 2)
            {
                background = RoomSpriteFactory.Instance.CreateRoom2();
            }
            else if (roomNumber == 3)
            {
                background = RoomSpriteFactory.Instance.CreateRoom3();
            }
            else if (roomNumber == 4)
            {
                background = RoomSpriteFactory.Instance.CreateRoom4();
            }
            else if (roomNumber == 5)
            {
                background = RoomSpriteFactory.Instance.CreateRoom5();
            }
            else if (roomNumber == 6)
            {
                background = RoomSpriteFactory.Instance.CreateRoom6();
            }
            else if (roomNumber == 7)
            {
                background = RoomSpriteFactory.Instance.CreateRoom7();
            }
            else if (roomNumber == 8)
            {
                background = RoomSpriteFactory.Instance.CreateRoom8();
            }
            else if (roomNumber == 9)
            {
                background = RoomSpriteFactory.Instance.CreateRoom9();
            }
            else if (roomNumber == 10)
            {
                background = RoomSpriteFactory.Instance.CreateRoom10();
            }
            else if (roomNumber == 11)
            {
                background = RoomSpriteFactory.Instance.CreateRoom11();
            }
            else if (roomNumber == 12)
            {
                background = RoomSpriteFactory.Instance.CreateRoom12();
            }
            else if (roomNumber == 13)
            {
                background = RoomSpriteFactory.Instance.CreateRoom13();
            }
            else if (roomNumber == 14)
            {
                background = RoomSpriteFactory.Instance.CreateRoom14();
            }
            else if (roomNumber == 15)
            {
                background = RoomSpriteFactory.Instance.CreateRoom15();
            }
            else if (roomNumber == 16)
            {
                background = RoomSpriteFactory.Instance.CreateRoom16();
            }
            else if (roomNumber == 18) // test room
            {
                background = RoomSpriteFactory.Instance.CreateRoom0();
            }
            else // room 17
            {
                background = RoomSpriteFactory.Instance.CreateRoom17();
            }
            return background;
        }

        public ISet<IEnemy> LoadEnemies()
        {
            ISet<IEnemy> enemies = new HashSet<IEnemy>();
            IDictionary<Vector2, string> enemyInfo = parser.Enemies;
            foreach (KeyValuePair<Vector2, String> entry in enemyInfo)
            {
                IEnemy enemy;
                if (entry.Value.Equals("Aquamentus"))
                {
                    enemy = new Aquamentus(this.game);
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
                enemy.Y = (int)entry.Key.Y;
                enemies.Add(enemy);
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
                item.Y = (int)entry.Key.Y;
                items.Add(item);
            }
            return items;
        }

        public IList<IBlock> LoadBlocks(IRoom room)
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
                else if (entry.Value.Equals("MoveableBlockVertical"))
                {
                    block = new MoveableBlockVertical(room);
                }
                else if (entry.Value.Equals("MoveableBlockLeft"))
                {
                    block = new MoveableBlockLeft(room);
                }

                if (block != null)
                {
                    block.X = (int)entry.Key.X;
                    block.Y = (int)entry.Key.Y;
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
                }
                else if (entry.Key.Equals("up"))
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
                }
                else 
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
                    npc = new OldMan();
                }
                else
                {
                    npc = new Merchant();
                }
                npc.X = (int)entry.Key.X;
                npc.Y = (int)entry.Key.Y;
                npcs.Add(npc);
            }

            return npcs;
        }

    }
}
