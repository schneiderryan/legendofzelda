using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class PlayerMoveUpCommand : IPlayerCommand
    {
        private IPlayer player;

        public PlayerMoveUpCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.MoveUp();
        }
    }
}
