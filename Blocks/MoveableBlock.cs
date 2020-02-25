using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda.Blocks
{
    interface IMoveableBlock : IBlock
    {
        void Draw(SpriteBatch sb);
    }
}
