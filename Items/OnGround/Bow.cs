
namespace LegendOfZelda
{
    class Bow : Item
    {
        public Bow()
        {
            sprite = ItemSpriteFactory.GetBow();
            Hitbox = sprite.Box;
        }

        public override void Collect(IPlayer player)
        {
            player.Inventory.BowAndArrow.FoundBow();
        }
    }
}
