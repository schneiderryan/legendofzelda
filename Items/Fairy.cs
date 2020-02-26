
namespace LegendOfZelda
{
    class Fairy : Item
    {
        public Fairy()
        {
            sprite = ItemSpriteFactory.GetFairy();
            Hitbox = sprite.Box;
        }

        public override void Update()
        {
            sprite.Update();
        }

        public override void Use(IPlayer player)
        {
            player.currentHearts = player.maxHearts;
        }
    }
}
