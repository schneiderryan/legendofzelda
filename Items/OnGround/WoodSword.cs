
namespace LegendOfZelda
{
    class WoodSword : Item, ILeveledItem
    {
        public ItemLevel Level { get; } = ItemLevel.Wood;
        public int Damage => 1;

        public WoodSword()
        {
            sprite = ItemSpriteFactory.GetWoodSword();
            Hitbox = sprite.Box;
        }

        public override void Collect(IPlayer player)
        {
            if (player.Inventory.Sword.Level < Level)
            {
                player.Inventory.Sword = this;
            }
        }
    }
}
