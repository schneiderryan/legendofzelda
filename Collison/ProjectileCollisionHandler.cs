using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace LegendOfZelda
{
    class ProjectileCollisionHandler
    {
        private IList<IProjectile> projectiles;
        private IList<IDespawnEffect> effects;

        public ProjectileCollisionHandler(IList<IProjectile> projectiles,
                IList<IDespawnEffect> effects)
        {
            this.projectiles = projectiles;
            this.effects = effects;
        }

        public void HandleCollisions(IRoom room)
        {
            ProjectileEnemyCollision(room.Enemies);
            ProjectileCollision(room.Hitboxes);
            ProjectileDoorCollision(room.Doors.Values);
            EnemyProjectileCollision(room.Enemies, projectiles);
            
            
        }

        private void ProjectileCollision(IList<Rectangle> boxes)
        {
            IList<int> despawn = new List<int>();
            for (int pos = 0; pos < projectiles.Count; pos++)
            {
                foreach (Rectangle box in boxes)
                {
                    IProjectile p = projectiles[pos];
                    // wait for the projcetile to inside a wall before despawning
                    if (box.Contains(p.Hitbox.Center))
                    {
                        despawn.Add(pos);
                        break;
                    }
                }
            }

            for (int i = despawn.Count - 1; i >= 0; i--)
            {
                effects.Add(projectiles[despawn[i]].GetDespawnEffect());
                projectiles.RemoveAt(despawn[i]);
            }
        }

        private void ProjectileDoorCollision(ICollection<IDoor> doors)
        {
            IList<Rectangle> hitboxes = new List<Rectangle>();
            foreach (IDoor door in doors)
            {
                hitboxes.Add(door.Hitbox);
            }
            ProjectileCollision(hitboxes);
        }

        private void ProjectileEnemyCollision(ICollection<IEnemy> enemies)
        {
            IList<Rectangle> hitboxes = new List<Rectangle>();
            foreach (IEnemy enemy in enemies)
            {
                hitboxes.Add(enemy.Hitbox);
                
            }
            ProjectileCollision(hitboxes);
            
        }


        private static void EnemyProjectileCollision(IList<IEnemy> enemies, IList<IProjectile> projectiles)
        {
            List<IProjectile> projectilesToRemove = new List<IProjectile>();
            foreach (IEnemy enemy in enemies)
            {
                foreach (IProjectile projectile in projectiles)
                {
                    Rectangle collision = Rectangle.Intersect(enemy.Hitbox, projectile.Hitbox);
                    if (!collision.Equals(Rectangle.Empty))
                    {
                        HandleEnemyProjectileCollision(enemy, collision);
                        projectilesToRemove.Add(projectile);
                    }
                }
            }
            foreach (IProjectile toRemove in projectilesToRemove)
            {
                projectiles.Remove(toRemove);
            }
        }

        public static void HandleEnemyProjectileCollision(IEnemy enemy, in Rectangle collision)
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y != enemy.Hitbox.Y)
                {
                    enemy.Y -= collision.Height;
                    System.Diagnostics.Debug.WriteLine("take damage");
                    enemy.TakeDamage();


                }
                else
                {
                    enemy.Y += collision.Height;
                    System.Diagnostics.Debug.WriteLine("take damage");
                    enemy.TakeDamage();
                }
            }
            else
            {
                if (collision.X != enemy.Hitbox.X)
                {
                    enemy.X -= collision.Width;
                    System.Diagnostics.Debug.WriteLine("take damage");
                    enemy.TakeDamage();
                }
                else
                {
                    enemy.X += collision.Width;
                    System.Diagnostics.Debug.WriteLine("take damage");
                    enemy.TakeDamage();
                }
            }
        }
    }
}
