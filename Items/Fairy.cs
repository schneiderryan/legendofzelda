
namespace LegendOfZelda
{
    class Fairy : Item
    {
        public Fairy()
        {
            sprite = ItemSpriteFactory.GetFairy();
            Hitbox = sprite.Box;
        }

        public override void Use(IPlayer player)
        {
            player.CurrentHearts = player.MaxHearts;
        }
    }
}
