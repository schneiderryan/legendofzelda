

namespace LegendOfZelda
{
    interface IHeldItem : IDrawable
    {
        void Use(IPlayer player);
        int X { get; set; }
        int Y { get; set; }
    }
}
