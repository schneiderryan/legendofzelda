using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class HUDMap
    {
        private LegendOfZelda game;
        private Texture2D map = Textures.GetMap();
        private ISprite whiteBox = FontSpriteFactory.GetWhiteBox();
        private int offset;
        private int[] room0;
        private int[] room1;
        private int[] room2;
        private int[] room3;
        private int[] room4;
        private int[] room5;
        private int[] room6;
        private int[] room7;
        private int[] room8;
        private int[] room9;
        private int[] room10;
        private int[] room11;
        private int[] room12;
        private int[] room13;
        private int[] room14;
        private int[] room15;
        private int[] room16;


        public HUDMap(LegendOfZelda game)
        {
            this.game = game;
            
        }

        public void Update()
        {
            offset = game.hud.offset;
            whiteBox = MoveThatBox(whiteBox, game, offset);
        }

        public void Draw()
        {
            if (game.link.Inventory.HasMap)
            {
                game.spriteBatch.Draw(map, new Rectangle(45, offset + 47, 100, 48), new Rectangle(0, 0, 94, 46), Color.White);
            }
            whiteBox.Draw(game.spriteBatch);
        }

        private static ISprite MoveThatBox(ISprite sprite, LegendOfZelda game, int offset)
        {

            ISprite temp = sprite;

            switch (game.roomIndex)
            {
                case 1:
                    temp.X = 84;
                    temp.Y = 90;
                    break;
                case 2:
                    temp.X = 101;
                    temp.Y = 90;
                    break;
                case 3:
                    temp.X = 84;
                    temp.Y = 82;
                    break;
                case 4:
                    temp.X = 68;
                    temp.Y = 73;
                    break;
                case 5:
                    temp.X = 84;
                    temp.Y = 73;
                    break;
                case 6:
                    temp.X = 101;
                    temp.Y = 73;
                    break;
                case 7:
                    temp.X = 52;
                    temp.Y = 65;
                    break;
                case 8:
                    temp.X = 68;
                    temp.Y = 65;
                    break;
                case 9:
                    temp.X = 84;
                    temp.Y = 65;
                    break;
                case 10:
                    temp.X = 101;
                    temp.Y = 65;
                    break;
                case 11:
                    temp.X = 118;
                    temp.Y = 65;
                    break;
                case 12:
                    temp.X = 84;
                    temp.Y = 57;
                    break;
                case 13:
                    temp.X = 118;
                    temp.Y = 57;
                    break;
                case 14:
                    temp.X = 135;
                    temp.Y = 57;
                    break;
                case 15:
                    temp.X = 68;
                    temp.Y = 49;
                    break;
                case 16:
                    temp.X = 84;
                    temp.Y = 49;
                    break;
                default:
                    temp.X = 68;
                    temp.Y = 90;
                    break;
            }
            temp.Y += offset;
            return temp;
        }
    }
}
