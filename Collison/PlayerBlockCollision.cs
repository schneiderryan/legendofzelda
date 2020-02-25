using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PlayerBlockCollision : ICollision
    {
        private IPlayer player;
        private IBlock block;
        private String direction;
        
        public String Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public PlayerBlockCollision(IPlayer player, IBlock block)
        {
            this.player = player;
            this.block = block;
            this.direction = player.direction;
        }

        public void Handle()
        {
            if (direction.Equals("up"))
            {
                player.yPos += 5;
            } 
            else if (direction.Equals("down")){
                player.yPos -= 5;
            }
            else if (direction.Equals("right"))
            {
                player.xPos -= 5;
            }
            else if (direction.Equals("left"))
            {
                player.xPos += 5;
            }
        }
    }
}
