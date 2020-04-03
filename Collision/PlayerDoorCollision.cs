using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class PlayerDoorCollision : ICollision
    {
        private IPlayer player;
        private Rectangle collision;
        private IDictionary<string, IDoor> doors;
        private KeyValuePair<string, IDoor> door;

        public PlayerDoorCollision(IDictionary<string, IDoor> doors,
                KeyValuePair<string, IDoor> door, IPlayer player, 
                in Rectangle collision)
        {
            this.player = player;
            this.collision = collision;
            this.doors = doors;
            this.door = door;
        }

        public void Handle()
        {
            if (!(door.Value is TopOpen || door.Value is BottomOpen
                    || door.Value is LeftOpen || door.Value is RightOpen))
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
                if (door.Value is TopKey)
                {
                    doors.Remove(door);
                    doors.Add("top", new TopOpen());
                }
            }
        }
    }
}
