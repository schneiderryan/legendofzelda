

namespace LegendOfZelda
{
    class Bomb : Item
    {
        public Bomb()
        {
            sprite = ItemSpriteFactory.GetBomb();
            sprite.Scale = 2;
            Hitbox = sprite.Box;
        }

        public override void Pickup(IPlayer player)
        {
            player.Inventory.Bombs += 1;
        }
    }
}
