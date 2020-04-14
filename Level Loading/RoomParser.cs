using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;


namespace LegendOfZelda
{
    class RoomParser
    {
        public int RoomNumber { get; private set; }
        public IDictionary<Vector2, string> Blocks { get; private set; }
        public IDictionary<string, string> Doors { get; private set; }
        public IDictionary<Vector2, string> Enemies { get; private set; }
        public IDictionary<Vector2, string> Items { get; private set; }
        public IDictionary<Vector2, string> NPCs { get; private set; }
        public const int TILE_SIZE = 32;

        private const int X_OFFSET = TILE_SIZE; //offset caused by level background
        private const int Y_OFFSET = TILE_SIZE; //offset caused by level background
        private const int LEVEL_WIDTH = 12; //grid spaces across
        private const int BOX_SIZE = TILE_SIZE / 2; //size of one of the dungeon grid spaces

        private IList<string> possibleEnemies;
        private IList<string> possibleItems;
        private IList<string> possibleBlocks;
        private IList<string> possibleDoors;
        private IList<string> possibleNPCs;

        public RoomParser()
        {
            this.possibleEnemies = new List<string>()
            {
                "Aquamentus",
                "Dodongo",
                "Gel",
                "Goriya",
                "Keese",
                "LFWallmaster",
                "RFWallmaster",
                "Snake",
                "Stalfo",
                "Fire",
                "Zol",
                "Trap",
            };

            this.possibleNPCs = new List<string>()
            {
                "OldMan",
                "Merchant",
            };

            this.possibleItems = new List<string>()
            {
                "Arrow",
                "BlueCandle",
                "BluePotion",
                "BlueRing",
                "BlueRupee",
                "Bomb",
                "Boomerang",
                "Bow",
                "Clock",
                "Compass",
                "Fairy",
                "Heart",
                "HeartContainer",
                "Key",
                "Map",
                "RedPotion",
                "RedRing",
                "Rupee",
                "TriforceShard",
                "WhiteSword",
                "WoodSword",
            };

            this.possibleBlocks = new List<string>()
            {
                "Block",
                "MoveableBlockVertical",
                "MoveableBlockLeft",
                "StairUp",
                "StairDown",
            };

            this.possibleDoors = new List<string>()
            {
                "Wall",
                "Open",
                "Key",
                "Other",
                "Exploded",
            };

            Clear();
        }

        public void Parse(string roomFileName)
        {
            Clear();

            using(StreamReader level = new StreamReader(roomFileName))

            {
                RoomNumber = ParseRoomNumber(level);
                Doors = ParseDoors(level);

                int y = 0;
                while (!level.EndOfStream)
                {
                    IDictionary<Vector2, string> line = NextLine(level, y);
                    foreach (KeyValuePair<Vector2, string> pair in line)
                    {
                        if (ParsePair(pair))
                        {
                            System.Diagnostics.Debug.WriteLine("Ignoring unkown value: " + pair);
                        }
                    }
                    y++;
                }
                level.Close();
            }
        }

        private void Clear()
        {
            RoomNumber = -1;
            Blocks = new Dictionary<Vector2, string>();
            Doors = new Dictionary<string, string>();
            Enemies = new Dictionary<Vector2, string>();
            Items = new Dictionary<Vector2, string>();
            NPCs = new Dictionary<Vector2, string>();
        }

        private bool ParsePair(KeyValuePair<Vector2, string> pair)
        {
            if (possibleBlocks.Contains(pair.Value))
            {
                Blocks.Add(pair);
            }
            else if (possibleEnemies.Contains(pair.Value))
            {
                Enemies.Add(pair);
            }
            else if (possibleItems.Contains(pair.Value))
            {
                Items.Add(pair);
            }
            else if (possibleNPCs.Contains(pair.Value))
            {
                NPCs.Add(pair);
            }
            else if (!pair.Value.Equals("Null"))
            {
                return true;
            }
            return false;
        }

        private static int ParseRoomNumber(StreamReader level)
        {
            string line = level.ReadLine();
            return int.Parse(line);
        }

        private Dictionary<String, String> ParseDoors(StreamReader level)
        {
            Dictionary<String, String> dictionary = new Dictionary<String, String>();
            String line = level.ReadLine();
            String[] array = { "left", "right", "top", "bottom" };
            for (int x = 0; x < 4; x++)
            {
                String box = NextBox(ref line);
                if (possibleDoors.Contains(box))
                {
                    dictionary.Add(array[x], box);
                }
            }
            return dictionary;
        }

        private static IDictionary<Vector2, string> NextLine(StreamReader reader,
                int lineNumber)
        {
            IDictionary<Vector2, string> dictionary = new Dictionary<Vector2, string>();
            string line = reader.ReadLine();
            for (int x = 0; x < LEVEL_WIDTH; x++)
            {
                String box = NextBox(ref line);
                int xPos = 2 * (X_OFFSET + (x * BOX_SIZE));
                int yPos = 2 * (Y_OFFSET + (lineNumber * BOX_SIZE));
                dictionary.Add(new Vector2(xPos, yPos), box);
            }
            return dictionary;
        }

        private static String NextBox(ref String line)
        {
            int index = line.IndexOf(",");

            if(index == -1)
            {
                return line;
            }
            else
            {
                String box = line.Substring(0, index);
                line = line.Substring(index + 1);
                return box;
            }
        }
    }

}

