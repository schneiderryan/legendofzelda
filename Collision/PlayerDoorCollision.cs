using Microsoft.Xna.Framework;
using System;

namespace LegendOfZelda
{
    class PlayerDoorCollision
    {
        ICommand cmdLeft;
        ICommand cmdRight;
        ICommand cmdUp;
        ICommand cmdDown;
        public void Handle(IPlayer player, IDoor door, in Rectangle collision)
        {
            if(!(player.X > 449 && (door is RightWall || door is RightOther)))
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

        public void HandleEdge(IPlayer player, IDoor door, Rectangle collision, LegendOfZelda game)
        {
            cmdRight = new SwapRoomCommand(game, "next");
            cmdLeft = new SwapRoomCommand(game, "previous");
            cmdUp = new SwapRoomCommand(game, "up");
            cmdDown = new SwapRoomCommand(game, "down");
            //change rooms based on door collision
            if (door is TopOpen)
            {
                player.Y = 315;
                cmdUp.Execute();
            }
            if (door is BottomOpen)
            {
                System.Diagnostics.Debug.WriteLine("walk through bottom door");
                player.Y = 2;
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
                //game.roomIndex++;
                cmdRight.Execute();
                player.X = 2;
            }
        }
    }
}
