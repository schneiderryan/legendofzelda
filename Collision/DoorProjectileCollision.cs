using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class DoorProjectileCollision : ICollision
    {
        IDictionary<string, IDoor> doors;
        KeyValuePair<string, IDoor> door;
        IProjectileManager projectiles;
        IProjectile projectile;

        public DoorProjectileCollision(IDictionary<string, IDoor> doors,
                KeyValuePair<string, IDoor> door, IProjectileManager projectiles,
                IProjectile projectile)
        {
            this.doors = doors;
            this.door = door;
            this.projectiles = projectiles;
            this.projectile = projectile;
        }

        public void Handle()
        {
            if (projectile is Explosion
                    && door.Value.Hitbox.Contains(projectile.Hitbox.Center))
            {
                Debug.WriteLine(door.Key);
                switch (door.Key)
                {
                    case "left":
                        if (door.Value is LeftWall)
                        {
                            doors.Remove(door.Key);
                            doors.Add(door.Key, new LeftExploded());
                        }
                        break;
                    case "top":
                        if (door.Value is TopWall)
                        {
                            doors.Remove(door.Key);
                            doors.Add(door.Key, new TopExploded());
                        }
                        break;
                    case "right":
                        if (door.Value is RightWall)
                        {
                            doors.Remove(door.Key);
                            doors.Add(door.Key, new RightExploded());
                        }
                        break;
                    case "bottom":
                        if (door.Value is BottomWall)
                        {
                            doors.Remove(door.Key);
                            doors.Add(door.Key, new BottomExploded());
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
