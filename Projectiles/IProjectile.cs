using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public interface IProjectile
    {
        int X { get; }
        int Y { get; }
        void Update();
        void Draw(SpriteBatch sb);
    }
}
