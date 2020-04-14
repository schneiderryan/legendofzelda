using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class PlayerDoorCollision : ICollision
    {
        LegendOfZelda game;
        IPlayer player;
        IDictionary<string, IDoor> doors;
        KeyValuePair<string, IDoor> door;

        static ICommand cmdLeft;
        static ICommand cmdRight;
        static ICommand cmdUp;
        static ICommand cmdDown;

        public PlayerDoorCollision(IDictionary<string, IDoor> doors,
               KeyValuePair<string, IDoor> door, IPlayer player, LegendOfZelda game)
        {
            this.game = game;
            this.player = player;
            this.doors = doors;
            this.door = door;
        }

        public void Handle()
        {
            if (door.Value is TopOpen || door.Value is BottomOpen || door.Value is LeftOpen
                || door.Value is RightOpen)
            {
                if (door.Value.Hitbox.Contains(player.Hitbox))
                {
                    HandleEdge(player, door.Value, game);
                }
            }
            else if (door.Value is TopExploded || door.Value is BottomExploded
                || door.Value is LeftExploded || door.Value is RightExploded)
            {
                if (door.Value.Hitbox.Contains(player.Center))
                {
                    HandleEdge(player, door.Value, game, 32);
                }
            }
            else
            {
                if (!(player.X > 449 && (door.Value is RightWall || door.Value is RightOther
                    || door.Value is RightKey)) && !(player.Y == 435 && door.Value is BottomWall))
                {
                    Rectangle collision = Rectangle.Intersect(player.Footbox, door.Value.Hitbox);
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
                        if (game.roomIndex == 4)
                        {
                            game.rooms[8].Doors.Remove("bottom");
                            game.rooms[8].Doors.Add("bottom", new BottomOpen());
                        }
                    }
                    if(door.Value is RightKey && player.Inventory.Keys > 0)
                    {
                        Sounds.GetDoorUnlockSound().Play();
                        player.Inventory.Keys--;
                        doors.Remove(door);
                        doors.Add("right", new RightOpen());
                        game.rooms[game.roomIndex + 1].Doors.Remove("left");
                        game.rooms[game.roomIndex + 1].Doors.Add("left", new LeftOpen());
                    }
                    if (door.Value is LeftKey && player.Inventory.Keys > 0)
                    {
                        Sounds.GetDoorUnlockSound().Play();
                        player.Inventory.Keys--;
                        doors.Remove(door);
                        doors.Add("left", new LeftOpen());
                        game.rooms[game.roomIndex - 1].Doors.Remove("right");
                        game.rooms[game.roomIndex - 1].Doors.Add("right", new RightOpen());
                    }
                    if (door.Value is BottomKey && player.Inventory.Keys > 0)
                    {
                        Sounds.GetDoorUnlockSound().Play();
                        player.Inventory.Keys--;
                        doors.Remove(door);
                        doors.Add("bottom", new BottomOpen());
                        if (game.roomIndex == 8)
                        {
                            game.rooms[4].Doors.Remove("top");
                            game.rooms[4].Doors.Add("top", new TopOpen());
                        }
                    }
                }

            }
        }

        public void HandleEdge(IPlayer player, IDoor door, LegendOfZelda game, int margin = 8)
        {
            cmdRight = new SwapRoomCommand(game, "next");
            cmdLeft = new SwapRoomCommand(game, "previous");
            cmdUp = new SwapRoomCommand(game, "up");
            cmdDown = new SwapRoomCommand(game, "down");

            //change rooms based on door collision
            if ((door is TopOpen || door is TopExploded) && player.Hitbox.Top - door.Hitbox.Top < margin)
            {
                cmdUp.Execute();
                player.Y = 400;
            }
            if ((door is BottomOpen || door is BottomExploded) && door.Hitbox.Bottom - player.Hitbox.Bottom < margin)
            {
                cmdDown.Execute();
                player.Y = 180;
            }
            if ((door is LeftOpen || door is LeftExploded) && player.Hitbox.Left - door.Hitbox.Left < margin)
            {
                cmdLeft.Execute();
                player.X = 417;
            }
            if ((door is RightOpen || door is RightExploded) && door.Hitbox.Right - player.Hitbox.Right < margin)
            {
                cmdRight.Execute();
                player.X = 60;
            }
        }
    }
}
