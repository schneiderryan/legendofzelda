

namespace LegendOfZelda
{
    interface IProjectile : IDrawable, IUpdateable, ICollideable
    {
        IDespawnEffect GetDespawnEffect();
        Team OwningTeam { get; set; }
        double Damage { get; }
        double VX { get; }
        double VY { get; }
    }
}
