
namespace LegendOfZelda
{
    public class HeartContainer : Item
    {
        public HeartContainer()
        {
            sprite = ItemSpriteFactory.GetHeartContainer();
        }

        public override void Use(IPlayer player)
        {

        }
    }
}