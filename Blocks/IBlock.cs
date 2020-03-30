using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    interface IBlock : ICollideable
    {
        void Update();
        void Draw(SpriteBatch sb, Color color);
    }
}
