using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;


namespace LegendOfZelda
{

    static class ProjectileDespawner
    {
        private static ICollection<IProjectile> projectiles;
        private static ICollection<IDespawnEffect> effects;

        public static void Register(ICollection<IProjectile> projectiles,
                ICollection<IDespawnEffect> effects)
        {
            ProjectileDespawner.projectiles = projectiles;
            ProjectileDespawner.effects = effects;
        }

        public static void DespawnProjectiles(IRoom room, IPlayer player)
        {
            WallProjectileCollision(room.Hitboxes);
            DoorProjectileCollision(room.Doors.Values);
            CharacterProjectileCollision(player);
            EnemyProjectileCollision(room.Enemies);
        }

        private static bool CanDespawn(IProjectile projectile, ICharacter character)
        {
            return projectile.OwningTeam != character.Team
                || (projectile is BoomerangProjectile
                    && (projectile as BoomerangProjectile).IsOwner(character));
        }

        private static void CharacterProjectileCollision(ICharacter character)
        {
            ICollection<IProjectile> despawn = new List<IProjectile>();
            foreach (IProjectile p in projectiles)
            {
                if (character.Hitbox.Intersects(p.Hitbox)
                        && CanDespawn(p, character))
                {
                    despawn.Add(p);
                }
            }
            Despawn(despawn);
        }

        private static void WallProjectileCollision(IEnumerable<Rectangle> boxes)
        {
            ICollection<IProjectile> collisions = new List<IProjectile>();
            foreach (IProjectile p in projectiles)
            {
                foreach (Rectangle box in boxes)
                {
                    // wait for the projcetile to inside a wall before despawning
                    if (box.Contains(p.Hitbox.Center))
                    {
                        if (p is BoomerangProjectile)
                        {
                            (p as BoomerangProjectile).BeginReturning();
                        }
                        else
                        {
                            collisions.Add(p);
                        }
                        break;
                    }
                }
            }

            Despawn(collisions);
        }

        private static void DoorProjectileCollision(ICollection<IDoor> doors)
        {
            ICollection<Rectangle> hitboxes = new List<Rectangle>();
            foreach (IDoor door in doors)
            {
                hitboxes.Add(door.Hitbox);
            }
            WallProjectileCollision(hitboxes);
        }

        private static void EnemyProjectileCollision(ICollection<IEnemy> enemies)
        {
            foreach (IEnemy enemy in enemies)
            {
                CharacterProjectileCollision(enemy);
            }
        }

        private static void Despawn(ICollection<IProjectile> despawn)
        {
            foreach (IProjectile projectile in despawn)
            {
                projectiles.Remove(projectile);
                effects.Add(projectile.GetDespawnEffect());
                if (projectile is BoomerangProjectile)
                {
                    (projectile as BoomerangProjectile).Returned = true;
                }
            }
        }

    }
}
