﻿
namespace LegendOfZelda
{
    class Map : Item
    {
        public Map()
        {
            sprite = ItemSpriteFactory.GetMap();
            Hitbox = sprite.Box;
        }

        public override void Collect(IPlayer player)
        {
            player.Inventory.HasMap = true;
        }
    }
}
