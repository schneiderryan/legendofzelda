using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IProjectile : IDrawable, IUpdateable, ICollideable
    {
        IDespawnEffect GetDespawnEffect();
        Team OwningTeam { get; set; }
        double Damage { get; }
        int VX { get; }
        int VY { get; }
    }
}
