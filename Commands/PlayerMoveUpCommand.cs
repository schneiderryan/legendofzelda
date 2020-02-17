using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class PlayerMoveUpCommand : ICommand
    {
        private IPlayer player;

        public PlayerMoveUpCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            if (!player.IsAttacking())
            {
                player.MoveUp();
            }
        }
    }
}
