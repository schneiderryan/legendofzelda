using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IItem : ICollideable, IDrawable, IUpdateable
    {
        void Collect(IPlayer player);
    }
}
