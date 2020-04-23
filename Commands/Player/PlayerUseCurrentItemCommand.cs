using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerUseCurrentItemCommand : ICommand
    {

        private IPlayer player;
        private IProjectileManager projectiles;
        private ICommand command;

        public PlayerUseCurrentItemCommand(IPlayer player, IProjectileManager projectiles)
        {
            this.player = player;
            this.projectiles = projectiles;
        }

        public void Execute()
        {
            if (!(player.CurrentItem.ToString().Equals("LegendOfZelda.Boomerang") && (player.Inventory.Boomerang.Level == 0)))
            {
                if (player.CurrentItem.ToString().Equals("LegendOfZelda.Bomb"))
                {
                    command = new PlayerUseBombCommand(player, projectiles);
                }
                else if (player.CurrentItem.ToString().Equals("LegendOfZelda.Boomerang"))
                {
                    command = new PlayerUseBoomerangCommand(player);
                }
                else if (player.CurrentItem.ToString().Equals("LegendOfZelda.Arrow"))
                {
                    command = new PlayerUseArrowCommand(player);
                }
                else if (player.CurrentItem.ToString().Equals("LegendOfZelda.BlueCandle"))
                {
                    command = new PlayerUseBlueCandleCommand(player, projectiles);
                }
                else if (player.CurrentItem.ToString().Equals("LegendOfZelda.BluePotion"))
                {
                    command = new PlayerUseBluePotionCommand(player);
                }
                else if (player.CurrentItem.ToString().Equals("LegendOfZelda.RedPotion"))
                {
                    command = new PlayerUseRedPotionCommand(player);
                }
                command.Execute();
            }
        }
    }
}
