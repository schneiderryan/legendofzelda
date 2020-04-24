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
        private IPlayer player;

        public InventoryMoveCommand(LegendOfZelda game, String direction, IPlayer player)
        {
            this.game = game;
            this.direction = direction;
            this.player = player;
        }

        public void Execute()
        {
            itemSelected = false;
            string[] items = { "Boomerang", "Bomb", "Arrow", "BlueCandle", "BluePotion", "RedPotion" };
            i = 0;
            foreach (string item in items)
            {
                if (player.CurrentItem.ToString().Equals("LegendOfZelda." + item))
                {
                    currentIndex = i;
                }
                i++;
            }
            i = currentIndex;
            if (game.state is InventoryState)
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
                        if (player.Inventory.Boomerang.Level > 0)
                        {
                            player.CurrentItem = new Boomerang();
                            itemSelected = true;
                        }
                    }
                    else if (currentItem == "Bomb")
                    {
                        if (player.Inventory.Bombs > 0)
                        {
                            player.CurrentItem = new Bomb();
                            itemSelected = true;
                        }
                    }
                    else if (currentItem == "Arrow")
                    {
                        if (player.Inventory.HasArrow && player.Inventory.HasBow)
                        {
                            player.CurrentItem = new Arrow();
                            itemSelected = true;
                        }
                    } else if (currentItem == "BlueCandle")
                    {
                        if (player.Inventory.BlueCandle.Found)
                        {
                            player.CurrentItem = new BlueCandle();
                            itemSelected = true;
                        }
                    } else if (currentItem == "BluePotion")
                    {
                        if (player.Inventory.HasBluePotion)
                        {
                            player.CurrentItem = new BluePotion();
                            itemSelected = true;
                        }
                    } else if (currentItem == "RedPotion")
                    {
                        if (player.Inventory.HasRedPotion)
                        {
                            player.CurrentItem = new RedPotion();
                            itemSelected = true;
                        }
                    }
                }
            }
        }
    }
}
