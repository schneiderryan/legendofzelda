using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class InvisibleBlock : CollideableObject, IBlock
    {
        public InvisibleBlock()
        {
            Hitbox = new Rectangle(0, 0, 32, 32);
        }
    }
}
