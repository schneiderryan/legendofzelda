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

            if(!(player.X > 449 && (door is RightWall || door is RightOther || door is RightKey)) && !(player.Y == 315 && door is BottomWall))
            {
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
                cmdUp.Execute();
                player.Y = 300;
            }
            if (door is BottomOpen)
            {
                cmdDown.Execute();
                player.Y = 60;
            }
            if (door is LeftOpen)
            {
                cmdLeft.Execute();
                player.X = 417;
            }
            if (door is RightOpen)
            {
                cmdRight.Execute();
                player.X = 60;
            }
        }
    }
}
