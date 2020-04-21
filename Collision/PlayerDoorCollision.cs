using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class PlayerDoorCollision : ICollision
    {
        LegendOfZelda game;
        IPlayer player;
        Rectangle collision;
        IDictionary<string, IDoor> doors;
        KeyValuePair<string, IDoor> door;

        static ICommand cmdLeft;
        static ICommand cmdRight;
        static ICommand cmdUp;
        static ICommand cmdDown;
        static ICommand cmdLeftPortal;

        public PlayerDoorCollision(IDictionary<string, IDoor> doors,
               KeyValuePair<string, IDoor> door, IPlayer player,
               in Rectangle collision, LegendOfZelda game)
        {
            this.game = game;
            this.player = player;
            this.collision = collision;
            this.doors = doors;
            this.door = door;
        }

        public void Handle()
        {
            if (door.Value is TopOpen || door.Value is BottomOpen || door.Value is LeftOpen || door.Value is RightOpen || door.Value is LeftPortal)
            {
                HandleEdge(player, door.Value, collision, game);
            }
            else
            {
                if (!(player.X > 449 && (door is RightWall || door is RightOther || door is RightKey)) && !(player.Y == 435 && door is BottomWall))
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
                    if (door.Value is TopKey && player.Inventory.Keys > 0)
                    {
                        Sounds.GetDoorUnlockSound().Play();
                        player.Inventory.Keys--;
                        doors.Remove(door);
                        doors.Add("top", new TopOpen());
                    }
                    if(door.Value is RightKey && player.Inventory.Keys > 0)
                    {
                        Sounds.GetDoorUnlockSound().Play();
                        player.Inventory.Keys--;
                        doors.Remove(door);
                        doors.Add("right", new RightOpen());
                    }
                    if (door.Value is LeftKey && player.Inventory.Keys > 0)
                    {
                        Sounds.GetDoorUnlockSound().Play();
                        player.Inventory.Keys--;
                        doors.Remove(door);
                        doors.Add("left", new LeftOpen());
                    }
                    if (door.Value is BottomKey && player.Inventory.Keys > 0)
                    {
                        Sounds.GetDoorUnlockSound().Play();
                        player.Inventory.Keys--;
                        doors.Remove(door);
                        doors.Add("bottom", new BottomOpen());
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
            cmdLeftPortal = new PortalRoomCommand(game, "left");

            //change rooms based on door collision
            if (door is TopOpen)
            {
                cmdUp.Execute();
                player.Y = 400;
            }
            if (door is BottomOpen)
            {
                cmdDown.Execute();
                player.Y = 180;
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
            if (door is LeftPortal)
            {
                cmdLeftPortal.Execute();
                //player.X = 417;
            }
        }
    }
}
