

namespace LegendOfZelda
{
    class RedPotion : Item
    {
        public RedPotion()
        {
            sprite = ItemSpriteFactory.GetRedPotion();
            Hitbox = sprite.Box;
        }

        public override void Pickup(IPlayer player)
        {
            player.CurrentHearts = player.MaxHearts;
            player.Inventory.RedPotion = new HeldRedPotion();
        }
    }
}
