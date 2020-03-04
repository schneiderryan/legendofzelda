using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class Despawner
    {
        private ISet<IProjectile> projectiles;
        private IList<IDespawnEffect> effects;
        private ISet<IProjectile> toDespawn;

        public Despawner(ref ISet<IProjectile> projectiles,
                ref IList<IDespawnEffect> effects)
        {
            this.projectiles = projectiles;
            this.effects = effects;
            this.toDespawn = new HashSet<IProjectile>();
        }

        public void Execute(IRoom room, IPlayer player)
        {
            WallProjectileCollision(room.Hitboxes);
            DoorProjectileCollision(room.Doors.Values);
            CharacterProjectileCollision(player);
            EnemyProjectileCollision(room.Enemies);
            RemoveDeadEnemies(room.Enemies);
            RemoveFinshedEffects(effects);
            DespawnProjectiles();
        }

        private void CharacterProjectileCollision(ICharacter character)
        {
            foreach (IProjectile p in projectiles)
            {
                bool collision = character.Hitbox.Intersects(p.Hitbox);
                if (p is BoomerangProjectile)
                {
                    BoomerangProjectile bp = p as BoomerangProjectile;
                    if (bp.Returned)
                    {
                        toDespawn.Add(p);
                    }
                    else if (collision)
                    {
                        bp.BeginReturning();
                    }
                }
                else if (collision && p.OwningTeam != character.Team)
                {
                    toDespawn.Add(p);
                }
            }
        }

        private void WallProjectileCollision(IEnumerable<Rectangle> boxes)
        {
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
                            toDespawn.Add(p);
                        }
                        break;
                    }
                }
            }
        }

        private void DoorProjectileCollision(ICollection<IDoor> doors)
        {
            ICollection<Rectangle> hitboxes = new List<Rectangle>();
            foreach (IDoor door in doors)
            {
                hitboxes.Add(door.Hitbox);
            }
            WallProjectileCollision(hitboxes);
        }

        private void EnemyProjectileCollision(IList<IEnemy> enemies)
        {
            foreach (IEnemy enemy in enemies)
            {
                CharacterProjectileCollision(enemy);
            }
        }

        private static void RemoveDeadEnemies(IList<IEnemy> enemies)
        {
            for (int i = enemies.Count - 1; i >= 0; i--)
            {
                if (enemies[i].isDead)
                {
                    enemies.RemoveAt(i);
                    System.Diagnostics.Debug.WriteLine("enemy count: " + enemies.Count);
                }
            }
        }

        private static void RemoveFinshedEffects(IList<IDespawnEffect> effects)
        {
            for (int i = effects.Count - 1; i >= 0; i--)
            {
                if (effects[i].Finished)
                {
                    effects.RemoveAt(i);
                }
            }
        }

        private void DespawnProjectiles()
        {
            foreach (IProjectile projectile in toDespawn)
            {
                projectiles.Remove(projectile);
                effects.Add(projectile.GetDespawnEffect());
            }
            toDespawn.Clear();
        }

    }
}
