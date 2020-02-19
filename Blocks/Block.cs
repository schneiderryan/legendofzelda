using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    abstract class Block
    {
        protected ISprite sprite;

        public int X
        {
            get { return sprite.Position.X; }
            set
            {
                sprite.Position = new Point(value, sprite.Position.Y);
            }
        }

        public int Y
        {
            get { return sprite.Position.Y; }
            set
            {
                sprite.Position = new Point(sprite.Position.X, value);
            }
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }

        public virtual void Update()
        {
            sprite.Update();
        }

    }
}
