

namespace LegendOfZelda
{
    class BluePotion : Item
    {
        public BluePotion()
        {
            sprite = ItemSpriteFactory.GetBluePotion();
            Hitbox = sprite.Box;
        }

        public override void Collect(IPlayer player)
        {
            player.Inventory.HasBluePotion = true;
        }
    }
}
