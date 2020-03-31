

namespace LegendOfZelda
{
    class WhiteSword : Item, ILeveledItem
    {
        public ItemLevel Level { get; } = ItemLevel.Wood;
        public int Damage => 2;

        public WhiteSword()
        {
            sprite = ItemSpriteFactory.GetWhiteSword();
            Hitbox = sprite.Box;
        }

        public override void Collect(IPlayer player)
        {
            if (player.Inventory.Sword.Level < Level
                    && player.MaxHearts >= 5)
            {
                player.Inventory.Sword = this;
            }
        }
    }
}
