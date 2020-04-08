using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface ICollideable
    {
        Rectangle Hitbox { get; }

        int X { get; set; }
        int Y { get; set; }
    }
}