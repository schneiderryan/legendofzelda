

namespace LegendOfZelda
{
    interface IHeldItem : IDrawable
    {
        void Use();
        int X { get; set; }
        int Y { get; set; }
    }
}
