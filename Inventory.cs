

namespace LegendOfZelda
{
    class Inventory : IInventory
    {
        public BowAndArrow BowAndArrow { get; }
        public IHeldItem BluePotion { get; set; }
        public IHeldItem RedPotion { get; set; }

        public int Rupees { get; set; } = 999; // for testing, remove l8r
        public int Bombs { get; set; } = 999; // for testing, remove l8r
        public int Keys { get; set; } = 999; // for testing, remove l8r

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
