using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IDrawable
    {
        void Draw(SpriteBatch sb, Color color);
    }
}
