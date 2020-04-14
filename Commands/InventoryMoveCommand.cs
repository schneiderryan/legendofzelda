using System;


namespace LegendOfZelda
{
    class InventoryMoveCommand : ICommand
    {

        private LegendOfZelda game;
        private String direction;
        private int currentIndex;
        private int i;
        private string currentItem;
        private bool itemSelected;

        public InventoryMoveCommand(LegendOfZelda game, String direction)
        {
            this.game = game;
            this.direction = direction;
           
    }
        public void Execute()
        {
            itemSelected = false;
            string[] items = { "Boomerang", "Bomb", "Arrow" };
            i = 0;
            foreach (string item in items)
            {
                if (game.link.CurrentItem.ToString().Equals("LegendOfZelda." + item))
                {
                    currentIndex = i;
                }
                i++;
            }
            i = currentIndex;
            if (game.state.ToString().Equals("LegendOfZelda.InventoryState"))
            {
                while (!itemSelected)
                {
                    if (direction.ToString().Equals("right"))
                    {
                        currentIndex++;
                        if (currentIndex >= items.Length)
                        {
                            currentIndex = 0;
                        }
                    }
                    else
                    {
                        currentIndex--;
                        if (currentIndex < 0)
                        {
                            currentIndex = items.Length - 1;
                        }
                    }
                    currentItem = items[currentIndex];
                    if (currentIndex == i)
                    {
                        itemSelected = true; //if there are no items
                    }
                    else if (currentItem == "Boomerang")
                    {
                        if (game.link.Inventory.Boomerang.Level > 0)
                        {
                            game.link.CurrentItem = new Boomerang();
                            itemSelected = true;
                        }
                    }
                    else if (currentItem == "Bomb")
                    {
                        if (game.link.Inventory.Bombs > 0)
                        {
                            game.link.CurrentItem = new Bomb();
                            itemSelected = true;
                        }
                    }
                    else if (currentItem == "Arrow")
                    {
                        if (game.link.Inventory.HasArrow && game.link.Inventory.HasBow)
                        {
                            game.link.CurrentItem = new Arrow();
                            itemSelected = true;
                        }
                    }
                }
            }
        }
    }
}
