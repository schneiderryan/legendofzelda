using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace LegendOfZelda
{
    using Handler = ProjectileCollisionHandler;

    static class ProjectileCollisionDetector
    {
        private static ICollection<IProjectile> projectiles;

        public static void Register(ICollection<IProjectile> projectiles,
                ICollection<IDespawnEffect> effects)
        {
            ProjectileCollisionDetector.projectiles = projectiles;
            Handler.Register(projectiles, effects);
        }

        public static void HandleCollisions(IRoom room, IPlayer player)
        {
            ProjectileWallCollision(room.Hitboxes);
            ProjectileDoorCollision(room.Doors.Values);
            PlayerProjectileCollision(player);
        }

        private static void PlayerProjectileCollision(IPlayer player)
        {
            ICollection<IProjectile> despawn = new List<IProjectile>();
            foreach (IProjectile p in projectiles)
            {
                if (player.Hitbox.Intersects(p.Hitbox)
                        && p.Owner != player.Team)
                {
                    Handler.ProjectilePlayerCollision(player);
                    if (!(p is BoomerangProjectile))
                    {
                        despawn.Add(p);
                    }
                }
            }
            Handler.Despawn(despawn);
        }

        private static void ProjectileWallCollision(IEnumerable<Rectangle> boxes)
        {
            ICollection<IProjectile> collisions = new List<IProjectile>();
            foreach (IProjectile p in projectiles)
            {
                foreach (Rectangle box in boxes)
                {
                    // wait for the projcetile to inside a wall before despawning
                    if (box.Contains(p.Hitbox.Center) && !(p is BoomerangProjectile))
                    {
                        collisions.Add(p);
                        break;
                    }
                }
            }

            Handler.Despawn(collisions);
        }

        private static void ProjectileDoorCollision(ICollection<IDoor> doors)
        {
            ICollection<Rectangle> hitboxes = new List<Rectangle>();
            foreach (IDoor door in doors)
            {
                hitboxes.Add(door.Hitbox);
            }
            ProjectileWallCollision(hitboxes);
        }

    }
}
