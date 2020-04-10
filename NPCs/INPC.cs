

namespace LegendOfZelda
{
    interface INPC : ICollideable, IDrawable, IUpdateable
    {
        Team Team { get; }
    }
}
