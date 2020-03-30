using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IProjectile : IDrawable, IUpdateable, ICollideable
    {
        IDespawnEffect GetDespawnEffect();
        Team OwningTeam { get; set; }

        int VX { get; }
        int VY { get; }
    }
}
