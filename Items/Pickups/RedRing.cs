

namespace LegendOfZelda
{
    class RedRing : Item
    {
        public RedRing()
        {
            sprite = ItemSpriteFactory.GetRedRing();
            Hitbox = sprite.Box;
        }

        public override void Pickup(IPlayer player)
        {
            player.WearRedRing();
        }
    }
}
