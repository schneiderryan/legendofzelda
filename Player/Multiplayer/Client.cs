using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class Client
    {
        public Client()
        {

        }

        public void Update()
        {
            // if update ready
            // do update
            // update other player room info
        }

        private string StringifyPlayer(IPlayer player)
        {
            return "{"
                + "ID:" + player.ID
                + ",X:" + player.X
                + ",Y:" + player.Y
                + ",Command:BeStill"
                + "}";
        }
    }
}
