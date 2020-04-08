using System.Collections.Generic;


namespace LegendOfZelda
{
    class ItemPlayerCollision : ICollision
    {
        private ICollection<IItem> items;
        private IPlayer player;
        private IItem item;

        public ItemPlayerCollision(ICollection<IItem> items, IPlayer player, IItem item)
        {
            this.items = items;
            this.item = item;
            this.player = player;
        }

        public void Handle()
        {
            item.Collect(player);
            items.Remove(item);
        }
    }
}