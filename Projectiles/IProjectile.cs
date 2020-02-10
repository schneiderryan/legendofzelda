using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public interface IProjectile
    {
        void Update();
        void Draw(SpriteBatch sb);
    }
}
