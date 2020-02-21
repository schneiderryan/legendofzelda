
namespace LegendOfZelda
{
    class Key : Item
    {
        public Key()
        {
            sprite = ItemSpriteFactory.GetKey();
            Hitbox = sprite.Box;
        }

        public override void Use(IPlayer player)
        {

        }
    }
}
