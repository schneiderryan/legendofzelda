using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class PlayerMoveRightCommand : ICommand
    {
        private IPlayer player;

        public PlayerMoveRightCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            if (!player.IsAttacking())
            {
                player.MoveRight();
            }
        }
    }
}
