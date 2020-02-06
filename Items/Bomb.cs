
namespace LegendOfZelda
{
    public class Bomb : Item
    {
        public Bomb()
        {
            sprite = ItemSpriteFactory.GetBomb();
        }

        public void Detonate()
        {
            sprite = ItemSpriteFactory.GetExplodingBomb();
        }
    }
}
