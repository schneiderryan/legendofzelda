using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LegendOfZelda
{
    class LevelLoader
    {
        private LevelParser parser;
        private LegendOfZelda game;
        private List<String> possiblePlayers;
        private List<String> possibleEnemies;
        private List<String> possibleItems;
        private List<String> possibleBlocks;
        private List<String> possibleDoors;
        public LevelLoader(String level, LegendOfZelda game)
        {
            this.parser = new LevelParser(level);
            this.game = game;

            this.possiblePlayers = new List<String>();
            possiblePlayers.Add("Link");
            possiblePlayers.Add("RedLink");

            this.possibleEnemies = new List<String>();
            possibleEnemies.Add("Aquamentus");
            possibleEnemies.Add("Dodongo");
            possibleEnemies.Add("Gel");
            possibleEnemies.Add("Goriya");
            possibleEnemies.Add("Keese");
            possibleEnemies.Add("LFWallmaster");
            possibleEnemies.Add("RFWallmaster");
            possibleEnemies.Add("Snake");
            possibleEnemies.Add("Stalfo");
            possibleEnemies.Add("Trap");
            possibleEnemies.Add("OldMan");

            this.possibleItems = new List<String>();
            this.possibleItems.Add("Arrow");
            this.possibleItems.Add("BlueRupee");
            this.possibleItems.Add("Bomb");
            this.possibleItems.Add("Boomerang");
            this.possibleItems.Add("Bow");
            this.possibleItems.Add("Clock");
            this.possibleItems.Add("Compass");
            this.possibleItems.Add("Fairy");
            this.possibleItems.Add("Heart");
            this.possibleItems.Add("HeartContainer");
            this.possibleItems.Add("Key");
            this.possibleItems.Add("Map");
            this.possibleItems.Add("Rupee");
            this.possibleItems.Add("TriforceShard");
            this.possibleItems.Add("WoodSword");

            this.possibleBlocks = new List<String>()
            {
                "Block",
                "MoveableBlock"
            };

            this.possibleDoors = new List<String>();
            this.possibleDoors.Add("Wall");
            this.possibleDoors.Add("Open");
            this.possibleDoors.Add("Key");
            this.possibleDoors.Add("Other");
            this.possibleDoors.Add("Exploded");
        }

        public ISprite LoadBackground()
        {
            ISprite background;
            int roomNumber = parser.parseRoomNumber();
            if(roomNumber == 0)
            {
                background = RoomSpriteFactory.Instance.CreateRoom0();
            }
            else if(roomNumber == 1)
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
            else // room 16
            {
                background = RoomSpriteFactory.Instance.CreateRoom16();
            }
            return background;
        }

        public List<IPlayer> LoadPlayers()
        {
            List<IPlayer> players = new List<IPlayer>();
            Dictionary<Vector2, String> playerInfo = parser.parse(possiblePlayers);
            foreach(KeyValuePair<Vector2, String> entry in playerInfo)
            {
                IPlayer player;
                if (entry.Value.Equals("Link"))
                {
                    player = new GreenLink(this.game);
                } else
                {
                    player = new RedLink(this.game);
                }
                player.X = (int)entry.Key.X;
                player.Y = (int)entry.Key.Y;
                players.Add(player);
            }
            return players;
        }

        public List<IEnemy> LoadEnemies()
        {
            List<IEnemy> enemies = new List<IEnemy>();
            Dictionary<Vector2, String> enemyInfo = parser.parse(possibleEnemies);
            foreach (KeyValuePair<Vector2, String> entry in enemyInfo)
            {
                IEnemy enemy;
                if (entry.Value.Equals("Aquamentus"))
                {
                    enemy = new Aquamentus(this.game);
                }
                else if(entry.Value.Equals("Gel"))
                {
                    enemy = new Gel();
                }
                else if (entry.Value.Equals("Goriya"))
                {
                    enemy = new Goriya();
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
                    enemy = new Snake();
                }
                else if (entry.Value.Equals("Dodongo"))
                {
                    enemy = new Dodongo();
                }
                else if (entry.Value.Equals("OldMan"))
                {
                    enemy = new OldMan(235,133);
                }
                else //trap
                {
                    enemy = new Trap();
                }
                enemy.X = (int)entry.Key.X;
                enemy.Y = (int)entry.Key.Y;
                enemies.Add(enemy);
            }
            return enemies;
        }

        public List<IItem> LoadItems()
        {
            List<IItem> items = new List<IItem>();
            Dictionary<Vector2, String> itemInfo = parser.parse(possibleItems);
            foreach (KeyValuePair<Vector2, String> entry in itemInfo)
            {
                IItem item;
                if (entry.Value.Equals("Arrow"))
                {
                    item = new Arrow();
                }
                else if(entry.Value.Equals("BlueRupee"))
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
                else if (entry.Value.Equals("Clock"))
                {
                    item = new Clock();
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
                    item = new TriforceShard();
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

        public List<IBlock> LoadStillBlocks()
        {
            List<IBlock> blocks = new List<IBlock>();
            Dictionary<Vector2, String> blockInfo = parser.parse(possibleBlocks);
            foreach (KeyValuePair<Vector2, String> entry in blockInfo)
            {
                IBlock block;
                if (entry.Value.Equals("Block"))
                {
                    block = new InvisibleBlock();
                    block.X = (int)entry.Key.X;
                    block.Y = (int)entry.Key.Y;
                    blocks.Add(block);
                }
            }
            return blocks;
        }

        public List<IMoveableBlock> LoadMoveableBlocks()
        {
            List<IMoveableBlock> blocks = new List<IMoveableBlock>();
            Dictionary<Vector2, String> blockInfo = parser.parse(possibleBlocks);
            foreach (KeyValuePair<Vector2, String> entry in blockInfo)
            {
                IMoveableBlock block;
                if (entry.Value.Equals("MoveableBlock"))
                {
                    block = new MovableBlock();
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
            Dictionary<String, String> doorInfo = parser.parseDoors(possibleDoors);
            
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
                        door = new LeftWall();
                    }
                    else if (entry.Value.Equals("Key"))
                    {
                        door = new LeftKey();
                    }
                    else if (entry.Value.Equals("Other"))
                    {
                        door = new LeftOther();
                    }
                    else {
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
                //check doors and add to doors
            }
            return doors;
        }
    }
}
