using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class HUDCounter
    {
        private LegendOfZelda game;
        private int count;
        private string type;
        private int xCoord;
        private int yCoord;
        private ISprite char1;
        private ISprite char2;
        private ISprite char3;
        private int offset;


        public HUDCounter(LegendOfZelda game, string type)
        {
            xCoord = 195;
            if (type.Equals("bombs"))
            {
                yCoord = 89; //change to right value
            }
            else if (type.Equals("rupees"))
            {
                yCoord = 35; //change to right value
            }
            else if (type.Equals("keys"))
            {
                yCoord = 70; //change to right value
            }
            this.game = game;
            count = 0;
            this.type = type;
        }

        public void Update()
        {
            if (type.Equals("bombs"))
            {
                count = game.Link.Inventory.Bombs;
            }
            else if (type.Equals("rupees"))
            {
                count = game.Link.Inventory.Rupees;
            }
            else if (type.Equals("keys"))
            {
                count = game.Link.Inventory.Keys;
            }
            this.offset = game.hud.offset;

        }

        public void Draw()
        {
            if (count < 100)
            {
                char1 = FontSpriteFactory.GetX();
                char2 = GetInt(count.ToString().Substring(0, 1));
                if (count.ToString().Length > 1)
                {
                    char3 = GetInt(count.ToString().Substring(1, 1));
                }
            }
            else
            {
                char1 = GetInt(count.ToString().Substring(0, 1));
                char2 = GetInt(count.ToString().Substring(1, 1));
                char3 = GetInt(count.ToString().Substring(2, 1));
            }

            //Get the coordinates of the characters
            char1.X = xCoord;
            char2.X = xCoord + 16;
            char1.Y = char2.Y = offset + yCoord;

            //Draw the characters
            char1.Draw(game.spriteBatch);
            char2.Draw(game.spriteBatch);
            if (char3 != null)
            {
                char3.X = xCoord + 32;
                char3.Y = offset + yCoord;
                char3.Draw(game.spriteBatch);

            }
        }

        private static ISprite GetInt(string str)
        {
            int integer = Int32.Parse(str);
            ISprite temp;

            switch (integer)
            {
                case 0:
                    temp = FontSpriteFactory.Get0();
                    break;
                case 1:
                    temp = FontSpriteFactory.Get1();
                    break;
                case 2:
                    temp = FontSpriteFactory.Get2();
                    break;
                case 3:
                    temp = FontSpriteFactory.Get3();
                    break;
                case 4:
                    temp = FontSpriteFactory.Get4();
                    break;
                case 5:
                    temp = FontSpriteFactory.Get5();
                    break;
                case 6:
                    temp = FontSpriteFactory.Get6();
                    break;
                case 7:
                    temp = FontSpriteFactory.Get7();
                    break;
                case 8:
                    temp = FontSpriteFactory.Get8();
                    break;
                case 9:
                    temp = FontSpriteFactory.Get9();
                    break;
                default:
                    temp = FontSpriteFactory.GetX();
                    break;
            }
            return temp;

        }
    }
}
