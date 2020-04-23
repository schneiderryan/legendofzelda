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
            if (game.Link.Inventory.HasMap)
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
