﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class PlayerUseBoomerangCommand : ICommand
    {
        private IPlayer player;

        public PlayerUseBoomerangCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.UseProjectile(new BoomerangProjectile(player.direction, player.xPos, player.yPos));
        }
    }
}
