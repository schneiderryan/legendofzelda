

namespace LegendOfZelda
{
    interface IInventory
    {
        BowAndArrow BowAndArrow { get; }
        IHeldItem BluePotion { get; set; }
        IHeldItem RedPotion { get; set; }
        bool HasClock { get; set; }
        bool HasMap { get; set; }

        int Rupees { get; set; }
        int Bombs { get; set; }
        int Keys { get; set; }
        int MaxBombs { get; set; }

        ILeveledItem Boomerang { get; set; }
        ILeveledItem Sword { get; set; }
        IHeldItem Offhand { get; set; }
    }
}
