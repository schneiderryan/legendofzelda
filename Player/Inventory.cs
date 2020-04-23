

namespace LegendOfZelda
{
    class Inventory : IInventory
    {
        public bool HasArrow { get; set; } = false;
        public bool HasBow { get; set; } = false;
        public bool HasBluePotion { get; set; } = false;
        public bool HasRedPotion { get; set; } = false;
        public bool HasClock { get; set; } = false;
        public HeldBlueCandle BlueCandle { get; set; }
        public bool HasMap { get; set; } = false;
        public bool HasCompass { get; set; } = true;
        public int Rupees { get; set; } = 0;
        public int Bombs { get; set; } = 0;
        public int Keys { get; set; } = 0;

        public int MaxBombs { get; set; } = 8;

        public ILeveledItem Boomerang { get; set; }
        public ILeveledItem Sword { get; set; }
        public IHeldItem Offhand { get; set; }

        public Inventory()
        {
            Sword = new EmptyLeveledItem();
            Boomerang = new EmptyLeveledItem();
            Offhand = new EmptyHeldItem();
            BlueCandle = new HeldBlueCandle();
        }

    }
}
