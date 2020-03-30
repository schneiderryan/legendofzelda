
namespace LegendOfZelda
{
    class Compass : Item
    {
        public Compass()
        {
            sprite = ItemSpriteFactory.GetCompass();
            Hitbox = sprite.Box;
        }

        public override void Pickup(IPlayer player)
        {

        }
    }
}
