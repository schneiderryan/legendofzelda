using Microsoft.Xna.Framework;
using System;

namespace LegendOfZelda
{
    class PlayerDoorCollision
    {

        static ICommand cmdLeft;
        static ICommand cmdRight;
        static ICommand cmdUp;
        static ICommand cmdDown;
        public static void Handle(IPlayer player, IDoor door, in Rectangle collision)

        {


            System.Diagnostics.Debug.WriteLine("collision data:\n door: " + door +"\nplayer.X: "+player.X+"\nplayer.Y: "+player.Y);

            
            if(!(player.X > 449 && (door is RightWall || door is RightOther)) && !(player.Y == 315 && door is BottomWall))
            {
                System.Diagnostics.Debug.WriteLine("cause collision");
                if (collision.Width > collision.Height)
                {
                    if (collision.Y != player.Footbox.Y)
                    {
                        player.Y -= collision.Height;
                    }
                    else
                    {
                        player.Y += collision.Height;
                    }
                }
                else
                {
                    if (collision.X > player.Footbox.X)
                    {
                        player.X -= collision.Width;
                    }
                    else
                    {
                        player.X += collision.Width;
                    }
                }
            }
            
        }

        public static void HandleEdge(IPlayer player, IDoor door, Rectangle collision, LegendOfZelda game)
        {
            cmdRight = new SwapRoomCommand(game, "next");
            cmdLeft = new SwapRoomCommand(game, "previous");
            cmdUp = new SwapRoomCommand(game, "up");
            cmdDown = new SwapRoomCommand(game, "down");
            //change rooms based on door collision
            if (door is TopOpen)
            {
                System.Diagnostics.Debug.WriteLine("walk through top door");
                player.Y = 315;
                cmdUp.Execute();
            }
            if (door is BottomOpen)
            {
                System.Diagnostics.Debug.WriteLine("walk through bottom door");
                player.Y = 5;
                cmdDown.Execute();
            }
            if (door is LeftOpen)
            {
                System.Diagnostics.Debug.WriteLine("walk through left door");
                cmdLeft.Execute();
                player.X = 465;
                
            }
            if (door is RightOpen)
            {
                System.Diagnostics.Debug.WriteLine("walk through right door");
                cmdRight.Execute();
                player.X = 2;
            }
        }
    }
}
