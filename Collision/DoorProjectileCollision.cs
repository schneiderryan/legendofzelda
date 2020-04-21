using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class DoorProjectileCollision : ICollision
    {
        IList<IRoom> rooms;
        int roomIndex;
        KeyValuePair<string, IDoor> door;
        IProjectileManager projectiles;
        IProjectile projectile;

        public DoorProjectileCollision(IList<IRoom> rooms, int roomIndex,
                KeyValuePair<string, IDoor> door, IProjectileManager projectiles,
                IProjectile projectile)
        {
            this.rooms = rooms;
            this.roomIndex = roomIndex;
            this.door = door;
            this.projectiles = projectiles;
            this.projectile = projectile;
        }

        public void Handle()
        {
            if (projectile is Explosion
                    && door.Value.Hitbox.Contains(projectile.Hitbox.Center))
            {
                switch (door.Key)
                {
                    case "top":
                        if (door.Value is TopWall && (roomIndex == 5 || roomIndex == 6))
                        {
                            rooms[roomIndex].Doors.Remove(door.Key);
                            rooms[roomIndex].Doors.Add(door.Key, new TopExploded());
                            rooms[roomIndex + 4].Doors.Remove("bottom");
                            rooms[roomIndex + 4].Doors.Add("bottom", new BottomExploded());
                        }
                        break;
                    case "bottom":
                        if (door.Value is BottomWall && (roomIndex == 9 || roomIndex == 10))
                        {
                            rooms[roomIndex].Doors.Remove(door.Key);
                            rooms[roomIndex].Doors.Add(door.Key, new BottomExploded());
                            rooms[roomIndex - 4].Doors.Remove("top");
                            rooms[roomIndex - 4].Doors.Add("top", new TopExploded());
                        }
                        break;
                }
            }
            else
            {
                new WallProjectileCollision(projectiles, projectile,
                        Rectangle.Intersect(door.Value.Hitbox, projectile.Hitbox)).Handle();
            }
        }
    }
}
