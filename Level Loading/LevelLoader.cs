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
        public LevelLoader(String level, LegendOfZelda game)
        {
            this.parser = new LevelParser(level);
            this.game = game;

            this.possiblePlayers = new List<String>();
            possiblePlayers.Add("Link");
            possiblePlayers.Add("RedLink");

            this.possibleEnemies = new List<String>();
            possibleEnemies.Add("Aquamentus");
            possibleEnemies.Add("Gel");
            possibleEnemies.Add("Goriya");
            possibleEnemies.Add("Keese");
            possibleEnemies.Add("LFWallmaster");
            possibleEnemies.Add("RFWallmaster");
            possibleEnemies.Add("Stalfo");
            possibleEnemies.Add("Trap");

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

            this.possibleBlocks = new List<String>();
            this.possibleBlocks.Add("StillBlock");
        }

        public List<IPlayer> loadPlayers()
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
                player.xPos = (int)entry.Key.X;
                player.yPos = (int)entry.Key.Y;
                players.Add(player);
            }
            return players;
        }

        public List<IEnemy> loadEnemies()
        {
            List<IEnemy> enemies = new List<IEnemy>();
            Dictionary<Vector2, String> enemyInfo = parser.parse(possibleEnemies);
            foreach (KeyValuePair<Vector2, String> entry in enemyInfo)
            {
                IEnemy enemy;
                if (entry.Value.Equals("Aquamentus"))
                {
                    enemy = new Aquamentus();
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

        public List<IItem> loadItems()
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

        public List<IBlock> loadBlocks()
        {
            List<IBlock> blocks = new List<IBlock>();
            Dictionary<Vector2, String> blockInfo = parser.parse(possibleBlocks);
            foreach (KeyValuePair<Vector2, String> entry in blockInfo)
            {
                IBlock block;
                if (entry.Value.Equals("StillBlock"))
                {
                    block = new StillBlock();
                }
                else
                {
                    block = new StillBlock();
                }
                block.X = (int)entry.Key.X;
                block.Y = (int)entry.Key.Y;
                blocks.Add(block);
            }
            return blocks;
        }
    }
}
