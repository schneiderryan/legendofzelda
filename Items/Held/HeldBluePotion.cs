

namespace LegendOfZelda
{
    class HeldBluePotion : HeldItem
    {
        public HeldBluePotion()
        {
            sprite = ItemSpriteFactory.GetBluePotion();
        }

        public override void Use(IPlayer player)
        {
            player.CurrentHearts = player.MaxHearts;
            player.Inventory.BluePotion = new EmptyHeldItem();
        }
    }
}
