using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class PlayerMoveLeftCommand : ICommand
    {
        private IPlayer player;

        public PlayerMoveLeftCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.MoveLeft();
        }
    }
}
