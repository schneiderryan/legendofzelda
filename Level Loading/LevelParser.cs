using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;


namespace LegendOfZelda
{
    class LevelParser
    {
        public const int TILE_SIZE = 32;
        private const int X_OFFSET = TILE_SIZE; //offset caused by level background
        private const int Y_OFFSET = TILE_SIZE; //offset caused by level background
        private const int LEVEL_WIDTH = 12; //grid spaces across
        private const int BOX_SIZE = 16; //size of one of the dungeon grid spaces
        private String levelName;

        public LevelParser(String levelName)
        {
            this.levelName = levelName;
        }

        public Dictionary<Vector2, String> Parse(IList<string> desiredStrings)
        {
            Dictionary<Vector2, String> dictionary = new Dictionary<Vector2, String>();
            using(StreamReader level = new StreamReader(levelName))
            {
                String line = level.ReadLine();
                level.ReadLine();
                int y = 0;
                while (!level.EndOfStream)
                {
                    line = level.ReadLine();
                    for(int x = 0; x < LEVEL_WIDTH; x++)
                    {
                        String box = NextBox(ref line);
                        if (desiredStrings.Contains(box))
                        {
                            int xPos = 2 * (X_OFFSET + (x * BOX_SIZE));
                            int yPos = 2 * (Y_OFFSET + (y * BOX_SIZE));
                            dictionary.Add(new Vector2(xPos, yPos), box);
                        }
                    }
                    y++;
                }
                level.Close();
            }
            return dictionary;
        }

        public int ParseRoomNumber()
        {
            int room;
            using(StreamReader level = new StreamReader(levelName))
            {
                String line = level.ReadLine();
                room = int.Parse(line);
                level.Close();
            }
            return room;
        }

        public Dictionary<String, String> ParseDoors(IList<String> desiredDoors)
        {
            Dictionary<String, String> dictionary = new Dictionary<String, String>();
            using(StreamReader level = new StreamReader(levelName))
            {
                String line = level.ReadLine();
                line = level.ReadLine();
                String[] array = { "left", "right", "up", "down" };
                for (int x = 0; x < 4; x++)
                {
                    String box = NextBox(ref line);
                    if (desiredDoors.Contains(box))
                    {
                        dictionary.Add(array[x], box);
                    }
                }
                level.Close();
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
