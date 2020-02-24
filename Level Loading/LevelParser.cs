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
        private const int LEVEL_WIDTH = 16; //grid spaces across
        private const int LEVEL_HEIGHT = 11; //grid spaes down
        private const int BOX_SIZE = 32; //size of one of the dungeon grid spaces
        public LevelParser(String levelName)
        {
            this.levelName = levelName;
        }

        public Dictionary<Vector2, String> parse(List<String> desiredStrings)
        {
            Dictionary<Vector2, String> dictionary = new Dictionary<Vector2, String>();
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
                            int xPos = (x * BOX_SIZE);
                            int yPos = (y * BOX_SIZE);
                            dictionary.Add(new Vector2(xPos, yPos), box);
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
