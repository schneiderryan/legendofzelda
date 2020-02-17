
namespace LegendOfZelda
{
    public class Fairy : Item
    {
        public Fairy()
        {
            sprite = ItemSpriteFactory.GetFairy();
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
