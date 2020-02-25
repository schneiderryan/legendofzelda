using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    interface ICollideableRoom
    {
        List<Rectangle> Hitboxes { get; }
       
    }
}
