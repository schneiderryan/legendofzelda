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
        private const int X_OFFSET = 100; //offset caused by level background
        private const int Y_OFFSET = 50; //offset caused by level background
        private const int LEVEL_WIDTH = 12; //grid spaces across
        private const int LEVEL_HEIGHT = 7; //grid spaes down
        private const int BOX_SIZE = 50; //size of one of the dungeon grid spaces
        public LevelParser(String levelName)
        {
            this.levelName = levelName;
        }

        public Dictionary<String, Vector2> parse(List<String> desiredStrings)
        {
            Dictionary<String, Vector2> dictionary = new Dictionary<String, Vector2>();
            using(StreamReader level = new StreamReader(levelName))
            {
                String line;
                int y = 0;
                while (!level.EndOfStream)
                {
                    line = level.ReadLine();
                    for(int x = 0; x < LEVEL_WIDTH; x++)
                    {
                        String box = nextBox(ref line);
                        if (desiredStrings.Contains(box))
                        {
                            int xPos = X_OFFSET + (x * BOX_SIZE);
                            int yPos = Y_OFFSET + (y * BOX_SIZE);
                            dictionary.Add(box, new Vector2(xPos, yPos));
                        }
                    }
                    y++;
                }
                level.Close();
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
