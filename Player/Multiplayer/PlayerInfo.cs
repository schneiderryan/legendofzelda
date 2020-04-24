using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerInfo
    {
        private IPlayer player;

        public int X => player.X;
        public int Y => player.Y;

        public PlayerInfo(IPlayer player)
        {
            this.player = player;
        }
    }
}
