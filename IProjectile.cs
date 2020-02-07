using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public interface IProjectile
    {
        float VX { get; set; }
        float VY { get; set; }
        int X { get; set; }
        int Y { get; set; }

        void Update();
        void Draw(SpriteBatch sb);
    }
}
