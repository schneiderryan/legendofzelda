

namespace LegendOfZelda
{
    
    interface INPC : ICollideable, IDrawable, IUpdateable
    {
        void TakeDamage();
        Team Team { get; }
    }
}
