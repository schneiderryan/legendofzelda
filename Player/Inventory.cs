

namespace LegendOfZelda
{
    class Inventory : IInventory
    {
        public BowAndArrow BowAndArrow { get; }
        public IHeldItem BluePotion { get; set; }
        public IHeldItem RedPotion { get; set; }
        public bool HasClock { get; set; } = false;

        public int Rupees { get; set; } = 255; // for testing, remove l8r
        public int Bombs { get; set; } = 8; // for testing, remove l8r
        public int Keys { get; set; } = 999; // for testing, remove l8r

        public int MaxBombs { get; set; } = 8;

        public ILeveledItem Boomerang { get; set; }
        public ILeveledItem Sword { get; set; }
        public IHeldItem Offhand { get; set; }

        public Inventory()
        {
            BowAndArrow = new BowAndArrow();

            Sword = new EmptyLeveledItem();
            Boomerang = new EmptyLeveledItem();

            RedPotion = new EmptyHeldItem();
            BluePotion = new EmptyHeldItem();
            Offhand = new EmptyHeldItem();
        }

    }
}
