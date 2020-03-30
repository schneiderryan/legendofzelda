
namespace LegendOfZelda
{
    class TriforceShard : Item
    {
        public TriforceShard()
        {
            sprite = ItemSpriteFactory.GetTriforceShard();
            Hitbox = sprite.Box;
        }

        public override void Pickup(IPlayer player)
        {

        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                        