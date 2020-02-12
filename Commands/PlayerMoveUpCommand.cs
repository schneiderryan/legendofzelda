﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerMoveUpCommand : ICommand
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
