

namespace LegendOfZelda
{
    interface IInventory
    {
        bool HasArrow { get; set; }
        bool HasBow { get; set; }
        bool HasBluePotion { get; set; }
        bool HasRedPotion { get; set; }
        bool HasClock { get; set; }
        bool HasMap { get; set; }
        bool HasCompass { get; set; }
        bool HasBlueCandle { get; set; }

        int Rupees { get; set; }
        int Bombs { get; set; }
        int Keys { get; set; }
        int MaxBombs { get; set; }

        ILeveledItem Boomerang { get; set; }
        ILeveledItem Sword { get; set; }
        IHeldItem Offhand { get; set; }
    }
}
