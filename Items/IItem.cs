using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public interface IItem
    {
        void Update();
        void Draw(SpriteBatch sb);
    }
}
