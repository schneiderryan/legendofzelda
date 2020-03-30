

namespace LegendOfZelda
{
    enum ItemLevel { None, Wood, White, Magical }

    interface ILeveledItem
    {
        ItemLevel Level { get; }
        int Damage { get; }
    }
}
