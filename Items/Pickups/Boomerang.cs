

namespace LegendOfZelda
{
    class Boomerang : Item, ILeveledItem
    {
        public ItemLevel Level { get; } = ItemLevel.Wood;
        public int Damage => 1;

        public Boomerang()
        {
            sprite = ItemSpriteFactory.GetBoomerang();
            Hitbox = sprite.Box;
        }

        public override void Pickup(IPlayer player)
        {
            if (player.Inventory.Boomerang.Level < Level)
            {
                player.Inventory.Boomerang = this;
            }
        }
    }
}
