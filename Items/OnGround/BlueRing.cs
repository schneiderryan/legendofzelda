﻿

namespace LegendOfZelda
{
    class BlueRing : Item
    {
        public BlueRing()
        {
            sprite = ItemSpriteFactory.GetBlueRing();
            Hitbox = sprite.Box;
        }

        public override void Collect(IPlayer player)
        {
            
        }
    }
}
