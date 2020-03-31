

namespace LegendOfZelda
{
    class HeldRedPotion : HeldItem
    {
        public HeldRedPotion()
        {
            sprite = ItemSpriteFactory.GetRedPotion();
        }

        public override void Use(IPlayer player)
        {
            player.CurrentHearts = player.MaxHearts;
            player.Inventory.RedPotion = new EmptyHeldItem();
            player.Inventory.BluePotion = new HeldBluePotion();
        }
    }
}
