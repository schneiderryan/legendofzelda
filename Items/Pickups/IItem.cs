using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IItem : ICollideable, IDrawable, IUpdateable
    {
        void Pickup(IPlayer player);
    }
}
