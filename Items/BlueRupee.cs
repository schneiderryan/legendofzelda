
namespace LegendOfZelda
{
    class BlueRupee : Item
    {
        public BlueRupee()
        {
            sprite = ItemSpriteFactory.GetBlueRupee();
            Hitbox = sprite.Box;
        }

        public override void Use(IPlayer player)
        {
            player.NumRupees = player.NumRupees + 5;
        }
    }
}
