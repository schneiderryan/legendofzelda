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
        }

        public List<IPlayer> loadPlayers()
        {
            List<IPlayer> players = new List<IPlayer>();
            Dictionary<String, Vector2> playerInfo = parser.parse(possiblePlayers);
            foreach(KeyValuePair<String, Vector2> entry in playerInfo)
            {
                IPlayer player;
                if (entry.Key.Equals("Link"))
                {
                    player = new GreenLink(this.game);
                } else
                {
                    player = new RedLink(this.game);
                }
                player.xPos = (int)entry.Value.X;
                player.yPos = (int)entry.Value.Y;
                players.Add(player);
            }
            return players;
        }

        public List<IEnemy> loadEnemies()
        {
            List<IEnemy> enemies = new List<IEnemy>();
            Dictionary<String, Vector2> enemyInfo = parser.parse(possibleEnemies);
            foreach (KeyValuePair<String, Vector2> entry in enemyInfo)
            {
                IEnemy enemy;
                if (entry.Key.Equals("Aquamentus"))
                {
                    enemy = new Aquamentus();
                }
                else if(entry.Key.Equals("Gel"))
                {
                    enemy = new Gel();
                }
                else if (entry.Key.Equals("Goriya"))
                {
                    enemy = new Goriya();
                }
                else if (entry.Key.Equals("Keese"))
                {
                    enemy = new Keese();
                }
                else if (entry.Key.Equals("LFWallmaster"))
                {
                    enemy = new LFWallmaster();
                }
                else if (entry.Key.Equals("RFWallmaster"))
                {
                    enemy = new RFWallmaster();
                }
                else if (entry.Key.Equals("Stalfo"))
                {
                    enemy = new Stalfo();
                }
                else //trap
                {
                    enemy = new Trap();
                }
                enemy.X = (int)entry.Value.X;
                enemy.Y = (int)entry.Value.Y;
                enemies.Add(enemy);
            }
            return enemies;
        }

        public List<IItem> loadItems()
        {
            List<IItem> items = new List<IItem>();
            Dictionary<String, Vector2> itemInfo = parser.parse(possibleItems);
            foreach (KeyValuePair<String, Vector2> entry in itemInfo)
            {
                IItem item;
                if (entry.Key.Equals("Arrow"))
                {
                    item = new Arrow();
                }
                else if(entry.Key.Equals("BlueRupee"))
                {
                    item = new BlueRupee();
                }
                else if (entry.Key.Equals("Bomb"))
                {
                    item = new Bomb();
                }
                else if (entry.Key.Equals("Bow"))
                {
                    item = new Bow();
                }
                else if (entry.Key.Equals("Clock"))
                {
                    item = new Clock();
                }
                else if (entry.Key.Equals("Compass"))
                {
                    item = new Compass();
                }
                else if (entry.Key.Equals("Fairy"))
                {
                    item = new Fairy();
                }
                else if (entry.Key.Equals("Heart"))
                {
                    item = new Heart();
                }
                else if (entry.Key.Equals("HeartContainer"))
                {
                    item = new HeartContainer();
                }
                else if (entry.Key.Equals("Key"))
                {
                    item = new Key();
                }
                else if (entry.Key.Equals("Map"))
                {
                    item = new Map();
                }
                else if (entry.Key.Equals("Rupee"))
                {
                    item = new Rupee();
                }
                else if (entry.Key.Equals("TriforceShard"))
                {
                    item = new TriforceShard();
                }
                else //wood sword
                {
                    item = new WoodSword();
                }
                item.X = (int)entry.Value.X;
                item.Y = (int)entry.Value.Y;
                items.Add(item);
            }
            return items;
        }
    }
}
