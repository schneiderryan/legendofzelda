

namespace LegendOfZelda
{
    class EmptyLeveledItem : ILeveledItem
    {
        public ItemLevel Level { get; } = ItemLevel.None;
        public int Damage => 1;
    }
}
