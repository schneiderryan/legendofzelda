using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    abstract class Block : IBlock
    {
        private Rectangle hitbox = new Rectangle(0, 0, 32, 32);

        public Rectangle Hitbox
        {
            get { return hitbox; }
        }
        public int X
        {
            get { return hitbox.X; }
            set { hitbox.X = value; }
        }

        public int Y
        {
            get { return hitbox.Y; }
            set { hitbox.Y = value; }
        }

    }
}
