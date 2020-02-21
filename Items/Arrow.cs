
namespace LegendOfZelda
{
    class Arrow : Item
    {
        public Arrow()
        {
            sprite = ItemSpriteFactory.GetArrow();
            Hitbox = sprite.Box;
        }

        public override void Use(IPlayer player)
        {

        }

    }
}
