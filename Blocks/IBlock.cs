using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    interface IBlock : ICollideable
    {
        int X { get; set; }
        int Y { get; set; }
    }
}
