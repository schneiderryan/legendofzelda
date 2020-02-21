using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    interface ICollideable
    {
        Rectangle Hitbox { get; }
        void Collide(ICollideable thing);
    }
}
