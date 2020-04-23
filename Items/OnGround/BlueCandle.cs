

namespace LegendOfZelda
{
    class BlueCandle : Item
    {
        public BlueCandle()
        {
            sprite = ItemSpriteFactory.GetBlueCandle();
            sprite.Scale = 2;
            Hitbox = sprite.Box;
        }

        public override void Collect(IPlayer player)
        {
            player.Inventory.BlueCandle.Found = true;
        }
    }
}
