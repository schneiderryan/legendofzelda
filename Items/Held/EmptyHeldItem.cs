﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    class EmptyHeldItem : IHeldItem
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw(SpriteBatch sb, Color color)
        {
            // do nothing
        }
    }
}
