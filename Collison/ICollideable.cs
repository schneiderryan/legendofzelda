using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface ICollideable
    {
        Rectangle Hitbox { get; }
    }
}
