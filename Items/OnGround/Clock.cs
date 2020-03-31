

namespace LegendOfZelda
{
    class Clock : Item
    {
        public Clock()
        {
            sprite = ItemSpriteFactory.GetClock();
            Hitbox = sprite.Box;
        }
        public override void Collect(IPlayer player)
        {
            //
        }
    }
}
