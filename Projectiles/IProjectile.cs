using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IProjectile : ICollideable
    {
        void Update();
        void Draw(SpriteBatch sb);
        IDespawnEffect GetDespawnEffect();
        Team Owner { get; set; }

        int VX { get; }
        int VY { get; }
    }
}
