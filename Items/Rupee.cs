
namespace LegendOfZelda
{
    class Rupee : Item
    {
        public Rupee()
        {
            sprite = ItemSpriteFactory.GetRupee();
            Hitbox = sprite.Box;
        }

        public override void Use(IPlayer player)
        {
            player.numRupees = player.numRupees + 1;
        }
    }
}
