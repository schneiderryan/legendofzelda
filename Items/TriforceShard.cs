
using System;

namespace LegendOfZelda
{
    class TriforceShard : Item
    {
        public TriforceShard()
        {
            sprite = ItemSpriteFactory.GetTriforceShard();
        }

        public override void Use(IPlayer player)
        {
            player.currentHearts = player.maxHearts;
        } 
    }
}
