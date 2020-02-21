using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IProjectile : ICollideable
    {
        int X { get; }
        int Y { get; }
        void Update();
        void Draw(SpriteBatch sb);
    }
}
