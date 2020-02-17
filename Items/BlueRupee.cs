
namespace LegendOfZelda
{
    public class BlueRupee : Item
    {
        public BlueRupee()
        {
            sprite = ItemSpriteFactory.GetBlueRupee();
        }

        public override void Update()
        {
            base.Update();
            
        }
        public override void Use(IPlayer player)
        {
            player.numRupees = player.numRupees + 5;
        }
    }
}
