using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerUseBombCommand : ICommand
    {
        private IPlayer player;

        public PlayerUseBombCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            Bomb bomb = new Bomb();
            player.UseItem(bomb);
        }
    }
}
