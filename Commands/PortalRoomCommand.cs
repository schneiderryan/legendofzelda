
using System;

namespace LegendOfZelda
{
    class PortalRoomCommand : ICommand
    {
        private LegendOfZelda game;
        private Random random = new Random();
        private int roomnumber;
        private IPlayer player;

        public PortalRoomCommand(LegendOfZelda game, IPlayer player)
        {
            this.game = game;
            this.player = player;
        }

        public void Execute()
        {
            System.Diagnostics.Debug.WriteLine("Started Portal command.");
            game.rooms[game.roomIndex].Players.Remove(player.ID);
            System.Diagnostics.Debug.WriteLine("Removed from old room.");
            game.rooms[game.roomIndex].Update();
            System.Diagnostics.Debug.WriteLine("Updated old room.");
            roomnumber = random.Next(0, 18);
            game.roomIndex = roomnumber;
            
            System.Diagnostics.Debug.WriteLine("Changed room index.");
            game.rooms[game.roomIndex].Players.Add(player.ID, player);
            System.Diagnostics.Debug.WriteLine("Added to new room.");
            game.rooms[game.roomIndex].Update();
            System.Diagnostics.Debug.WriteLine("Updated new room.");


            if (roomnumber == 7 || roomnumber == 15)  //Column 1
            {
                game.xRoom = 3;
            }
            else if (roomnumber == 16 || roomnumber == 8 || roomnumber == 4 || roomnumber == 0)  //Column 2
            {
                game.xRoom = 259;
            }
            else if (roomnumber == 17 || roomnumber == 12 || roomnumber == 9 || roomnumber == 5
                    || roomnumber == 3 || roomnumber == 1)  //Column 3
            {
                game.xRoom = 515;
            }
            else if (roomnumber == 10 || roomnumber == 6 || roomnumber == 2)  //Column 4
            {
                game.xRoom = 771;
            }
            else if (roomnumber == 13 || roomnumber == 11)  //Column 5
            {
                game.xRoom = 1027;
            }
            else  //must be room 14 and in Column 6
            {
                game.xRoom = 1283;
            }

            if (roomnumber == 15 || roomnumber == 16 || roomnumber == 17)  //Row 1
            {
                game.yRoom = -54;
            }
            else if (roomnumber == 12 || roomnumber == 13 || roomnumber == 14)  //Row 2
            {
                game.yRoom = 122;
            }
            else if (roomnumber == 7 || roomnumber == 8 || roomnumber == 9 || roomnumber == 10 || roomnumber == 11) //Row 3
            {
                game.yRoom = 298;
            }
            else if (roomnumber == 4 || roomnumber == 5 || roomnumber == 6)
            {
                game.yRoom = 474;
            }
            else if (roomnumber == 3)
            {
                game.yRoom = 650;
            }
            else if (roomnumber == 0 || roomnumber == 1 || roomnumber == 2)
            {
                game.yRoom = 826;
            }

            game.Link.X = 100;
            game.Link.Y = 300;

            System.Diagnostics.Debug.WriteLine("You are in room " + game.roomIndex);

            game.ProjectileManager.Clear();

        }
    }
}
