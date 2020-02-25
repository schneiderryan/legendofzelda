using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class RoomElementsSpriteFactory
    {
        private static Texture2D sheet = Textures.GetTileSheet();

        public static ISprite GetBlockSprite()
        {
            return new Sprite(sheet, new Rectangle(0, 0, 16, 16));
        }
    }
}
