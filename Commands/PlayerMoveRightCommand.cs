using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class PlayerMoveRightCommand : IPlayerCommand
    {
        private IPlayer player;

        public PlayerMoveRightCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.MoveRight();
        }
    }
}
