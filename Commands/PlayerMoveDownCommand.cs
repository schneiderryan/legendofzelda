﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class PlayerMoveDownCommand : ICommand
    {
        private IPlayer player;

        public PlayerMoveDownCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.MoveDown();
        }
    }
}