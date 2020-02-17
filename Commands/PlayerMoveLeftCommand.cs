﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
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
            if(!player.IsAttacking())
            {
                player.MoveLeft();
            }
        }
    }
}
