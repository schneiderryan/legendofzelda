using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class StillBlock : Block
    {
        public StillBlock()
        {
            Hitbox = new Rectangle(this.X, this.Y, 16, 16);
        }

        public override void Draw(SpriteBatch sb)
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {

        }
    }
}
