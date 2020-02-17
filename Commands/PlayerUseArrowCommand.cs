using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class PlayerUseArrowCommand : ICommand
    {
        private IPlayer player;

        public PlayerUseArrowCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            Bow bow = new Bow()
            {
                HasArrow = true
            };
            player.UseItem(bow);
        }
    }
}
