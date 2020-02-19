using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    interface IBlock
    {
        int X { get; set; }
        int Y { get; set; }
        void Update();
        void Draw(SpriteBatch sb);
    }
}
