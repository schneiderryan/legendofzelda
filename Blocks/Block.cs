using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    abstract class Block : IBlock
    {
        private int xPos;
        private int yPos;
        private ISprite blockSprite;
        public int X
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public int Y
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public abstract void Draw(SpriteBatch sb);

        public abstract void Update();

    }
}
