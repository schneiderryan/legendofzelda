using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LegendOfZelda
{
    class LevelParser
    {
        private String levelName;
        private const int X_OFFSET = 32; //offset caused by level background
        private const int Y_OFFSET = 32; //offset caused by level background
        private const int LEVEL_WIDTH = 12; //grid spaces across
        private const int BOX_SIZE = 16; //size of one of the dungeon grid spaces
        public LevelParser(String levelName)
        {
            this.levelName = levelName;
        }

        public Dictionary<Vector2, String> parse(List<String> desiredStrings)
        {
            Dictionary<Vector2, String> dictionary = new Dictionary<Vector2, String>();
            using(StreamReader level = new StreamReader(levelName))
            {
                String line = level.ReadLine();
                int y = 0;
                while (!level.EndOfStream)
                {
                    line = level.ReadLine();
                    for(int x = 0; x < LEVEL_WIDTH; x++)
                    {
                        String box = nextBox(ref line);
                        if (desiredStrings.Contains(box))
                        {
                            int xPos = 2 *(X_OFFSET + (x * BOX_SIZE));
                            int yPos = 2*(Y_OFFSET + (y * BOX_SIZE));
                            dictionary.Add(new Vector2(xPos, yPos), box);
                        }
                    }
                    y++;
                }
                level.Close();
            }
            return dictionary;
        }

        public Dictionary<String, String> parseDoors(List<String> desiredDoors)
        {
            Dictionary<String, String> dictionary = new Dictionary<String, String>();
            using(StreamReader level = new StreamReader(levelName))
            {
                String line = level.ReadLine();
                String[] array = { "left", "right", "up", "down" };
                for (int x = 0; x < 4; x++)
                {
                    String box = nextBox(ref line);
                    if (desiredDoors.Contains(box))
                    {
                        dictionary.Add(array[x], box);
                    }
                }
            }
            return dictionary;
        }

        private static String nextBox(ref String line)
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
