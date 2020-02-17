﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class PlayerStillCommand : ICommand
    {
        private IPlayer player;

        public PlayerStillCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.BeStill();
        }
    }
}
