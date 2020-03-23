using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class ItemPlayerCollision
    {
        private List<int> itemsToDespawnPositions;

        public ItemPlayerCollision(List<int> itemsToDespawnPositions)
        {
            this.itemsToDespawnPositions = itemsToDespawnPositions;
        }

        public void Handle(IPlayer player, IItem item, int postionInItemList)
        {
            player.UseItem(item);
            itemsToDespawnPositions.Add(postionInItemList);
        }
    }
}
