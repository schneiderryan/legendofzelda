﻿

namespace LegendOfZelda
{
    class BluePotion : Item
    {
        public BluePotion()
        {
            sprite = ItemSpriteFactory.GetBluePotion();
            Hitbox = sprite.Box;
        }

        public override void Pickup(IPlayer player)
        {
            player.CurrentHearts = player.MaxHearts;
            player.Inventory.RedPotion = new HeldBluePotion();
        }
    }
}
