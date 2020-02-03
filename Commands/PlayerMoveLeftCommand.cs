using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class PlayerMoveLeftCommand : IPlayerCommand
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
