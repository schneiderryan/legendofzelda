

namespace LegendOfZelda
{
    class BluePotion : Item
    {
        public BluePotion()
        {
            sprite = ItemSpriteFactory.GetBluePotion();
            Hitbox = sprite.Box;
        }

        public override void Collect(IPlayer player)
        {
            if ((!player.Inventory.HasBluePotion) && (!player.Inventory.HasRedPotion))
            {
                player.Inventory.HasBluePotion = true;
            } else if (player.Inventory.HasBluePotion && (!player.Inventory.HasRedPotion))
            {
                player.Inventory.HasRedPotion = true;
                player.Inventory.HasBluePotion = false;
            }
            if (player.CurrentItem.ToString().Equals("LegendOfZelda.BluePotion"))
            {
                player.CurrentItem = new RedPotion();
            }
        }
    }
}
