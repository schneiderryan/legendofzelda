

using System;

namespace LegendOfZelda
{
    class PortalRoomCommand : ICommand
    {
        private LegendOfZelda game;
        private string swapDirection;
        private Random random = new Random();
        private int roomnumber;
        

        public PortalRoomCommand(LegendOfZelda game, string direction)
        {
            this.game = game;
            this.swapDirection = direction;
            //roomnumber = random.Next(0, 18);
        }
        
        public void Execute()
        {
            roomnumber = random.Next(0, 18);
            game.roomIndex = roomnumber;
            if(swapDirection.Equals("left"))
            {
                game.link.X = 417;
            }
            game.ProjectileManager.Clear();

        }
    }
}
