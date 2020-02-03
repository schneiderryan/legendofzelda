using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class PlayerAttackCommand : IPlayerCommand
    {
        private IPlayer player;

        public PlayerAttackCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.Attack();
        }
    }
}
