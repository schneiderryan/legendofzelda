using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class MovableBlock : Block, IMoveableBlock
    {
        private ISprite sprite;

        public MovableBlock()
        {
            
        }

        public void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }

    }
}
