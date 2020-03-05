﻿using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class CollisionHandler
    {
        private ISet<IProjectile> projectilesToDespawn;
        private ISet<IEnemy> enemiesToDespawn;
        private SortedList<IItem, int> itemsToDespawn;
        private List<int> itemsToDespawnPositions;

        private PlayerWallCollision playerWallCollision;
        private PlayerBlockCollision playerBlockCollision;
        private PlayerEnemyCollision playerEnemyCollision;
        private PlayerProjectileCollision playerProjectileCollision;
        private ItemCollision itemCollision;

        private EnemyWallBlockCollision enemyWallBlockCollision;
        private EnemyProjectileCollision enemyProjectileCollision;

        private WallProjectileCollision wallProjectileCollision;

        private IList<IDespawnEffect> effects;

        private int currentPosition;

        public CollisionHandler(IList<IDespawnEffect> effects)
        {
            projectilesToDespawn = new HashSet<IProjectile>();
            enemiesToDespawn = new HashSet<IEnemy>();
            itemsToDespawn = new SortedList<IItem, int>();
            itemsToDespawnPositions = new List<int>();

            playerWallCollision = new PlayerWallCollision();
            playerBlockCollision = new PlayerBlockCollision();
            playerEnemyCollision = new PlayerEnemyCollision(enemiesToDespawn);
            playerProjectileCollision = new PlayerProjectileCollision(projectilesToDespawn);
            itemCollision = new ItemCollision(itemsToDespawnPositions);

            enemyWallBlockCollision = new EnemyWallBlockCollision();
            enemyProjectileCollision = new EnemyProjectileCollision(projectilesToDespawn, enemiesToDespawn);

            wallProjectileCollision = new WallProjectileCollision(projectilesToDespawn);

            this.effects = effects;
            currentPosition= 0;
        }

        public void Handle(IRoom room, ISet<IProjectile> projectiles, IPlayer player)
        {
            // handle all things player first
            HandlePlayerCollisions(room, projectiles, player);

            // handle all things enemy that haven't already been handled
            HandleEnemyCollisions(room, projectiles);

            // handle whatever's left
            HandleProjectileCollisions(room, projectiles);

            Despawn(projectiles, room.Enemies, room.Items);
            RemoveFinshedEffects();
        }

        private void HandlePlayerCollisions(IRoom room, ISet<IProjectile> projectiles,
                IPlayer player)
        {
            foreach (Rectangle wall in room.Hitboxes)
            {
                Rectangle collision = Rectangle.Intersect(wall, player.Footbox);
                if (!collision.IsEmpty)
                {
                    playerWallCollision.Handle(player, collision);
                }
            }

            foreach (IBlock block in room.Blocks)
            {
                Rectangle collision = Rectangle.Intersect(block.Hitbox, player.Footbox);
                if (!collision.IsEmpty)
                {
                    playerBlockCollision.Handle(player, block, collision);
                }
            }

            foreach (IEnemy enemy in room.Enemies)
            {
                Rectangle collision = Rectangle.Intersect(enemy.Hitbox, player.Hitbox);
                if (!collision.IsEmpty)
                {
                    playerEnemyCollision.Handle(player, enemy, collision);
                }
            }

            foreach (IProjectile projectile in projectiles)
            {
                Rectangle collision = Rectangle.Intersect(projectile.Hitbox, player.Hitbox);
                if (!collision.IsEmpty)
                {
                    playerProjectileCollision.Handle(player, projectile, collision);
                }

                //Boomerang Item Pickup Code
                if (projectile.GetType().ToString().Equals("LegendOfZelda.BoomerangProjectile") && projectile.OwningTeam.ToString().Equals("Link"))
                {
                    currentPosition = 0;
                    foreach (IItem item in room.Items)
                    {
                        collision = Rectangle.Intersect(item.Hitbox, projectile.Hitbox);
                        if (!collision.IsEmpty)
                        {
                            itemCollision.Handle(player, item, currentPosition);
                        }
                        currentPosition++;
                    }
                }
                

            }


            currentPosition= 0;
            foreach (IItem item in room.Items)
            {
                Rectangle collision = Rectangle.Intersect(item.Hitbox, player.Hitbox);
                if (!collision.IsEmpty)
                {
                    itemCollision.Handle(player, item, currentPosition);
                }
                currentPosition++;
            }
        }

        private void HandleEnemyCollisions(IRoom room, ISet<IProjectile> projectiles)
        {
            foreach (IEnemy enemy in room.Enemies)
            {
                foreach (Rectangle wall in room.Hitboxes)
                {
                    Rectangle collision = Rectangle.Intersect(wall, enemy.Hitbox);
                    if (!collision.IsEmpty)
                    {
                        enemyWallBlockCollision.Handle(enemy, collision);
                    }
                }

                foreach (IBlock block in room.Blocks)
                {
                    Rectangle collision = Rectangle.Intersect(block.Hitbox, enemy.Hitbox);
                    if (!collision.IsEmpty)
                    {
                        enemyWallBlockCollision.Handle(enemy, collision);
                    }
                }

                foreach (IProjectile projectile in projectiles)
                {
                    Rectangle collision = Rectangle.Intersect(projectile.Hitbox, enemy.Hitbox);
                    if (!collision.IsEmpty)
                    {
                        enemyProjectileCollision.Handle(enemy, projectile, collision);
                    }
                }
            }
        }

        private void HandleProjectileCollisions(IRoom room,
                ISet<IProjectile> projectiles)
        {
            foreach (IProjectile projectile in projectiles)
            {
                foreach (Rectangle wall in room.Hitboxes)
                {
                    Rectangle collision = Rectangle.Intersect(wall, projectile.Hitbox);
                    if (!collision.IsEmpty)
                    {
                        wallProjectileCollision.Handle(projectile, collision);
                    }
                }

                foreach (IDoor door in room.Doors.Values)
                {
                    Rectangle collision = Rectangle.Intersect(door.Hitbox, projectile.Hitbox);
                    if (!collision.IsEmpty)
                    {
                        wallProjectileCollision.Handle(projectile, collision);
                    }
                }

                // takes care of case where goriya dies b4 boomerang returns
                if ((projectile is BoomerangProjectile)
                    && (projectile as BoomerangProjectile).Returned)
                {
                    projectilesToDespawn.Add(projectile);
                }
            }
        }

        private void Despawn(ISet<IProjectile> projectiles, ISet<IEnemy> enemies, IList<IItem> items)
        {
            foreach (IProjectile projectile in projectilesToDespawn)
            {
                effects.Add(projectile.GetDespawnEffect());
            }

            enemies.ExceptWith(enemiesToDespawn);
            enemiesToDespawn.Clear();
            projectiles.ExceptWith(projectilesToDespawn);
            projectilesToDespawn.Clear();
            currentPosition= 0;
            foreach (int itemPosition in itemsToDespawnPositions)
            {
                if (items.Count == itemPosition)
                {
                    items.RemoveAt(itemPosition - 1);
                }
                else
                {
                    items.RemoveAt(itemPosition);
                }
            }
            itemsToDespawnPositions.Clear();
            
        }

        private void RemoveFinshedEffects()
        {
            for (int i = effects.Count - 1; i >= 0; i--)
            {
                if (effects[i].Finished)
                {
                    effects.RemoveAt(i);
                }
            }
        }

    }
}
