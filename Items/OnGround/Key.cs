
namespace LegendOfZelda
{
    class Key : Item
    {
        public Key()
        {
            sprite = ItemSpriteFactory.GetKey();
            Hitbox = sprite.Box;
        }

        public override void Collect(IPlayer player)
        {
            player.Inventory.Keys += 1;
        }
    }
}
