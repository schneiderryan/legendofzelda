

namespace LegendOfZelda
{
    class RedPotion : Item
    {
        public RedPotion()
        {
            sprite = ItemSpriteFactory.GetRedPotion();
            Hitbox = sprite.Box;
        }

        public override void Collect(IPlayer player)
        {
            player.Inventory.HasRedPotion = true;
        }
    }
}
