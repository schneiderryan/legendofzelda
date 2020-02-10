﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerAttackCommand : ICommand
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
