using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;


namespace LegendOfZelda
{
    class CollisionDetector
    {
        private LegendOfZelda game;
        private IProjectileManager projectileManager;
        private IList<ICollision> collisions;
        
        public CollisionDetector(IProjectileManager projectileManager, LegendOfZelda game)
        {

            this.game = game;
            collisions = new List<ICollision>();
            this.projectileManager = projectileManager;
            this.game = game;
        }

        public IEnumerable<ICollision> Detect(IRoom room, IPlayer player)
        {
            collisions.Clear();

            // handle all things player first

            HandlePlayerCollisions(room, player, game);

            // handle all things enemy that haven't already been handled
            HandleEnemyCollisions(room, player);

            // handle whatever's left
            HandleProjectileCollisions(room);

            return collisions;
        }


        private void HandlePlayerCollisions(IRoom room, IPlayer player, LegendOfZelda game)
        {
            if (!(player.State is GrabbedLinkState))
            {
                foreach (Rectangle wall in room.Hitboxes)
                {
                    Rectangle collision = Rectangle.Intersect(wall, player.Footbox);
                    if (!collision.IsEmpty)
                    {
                        collisions.Add(new PlayerWallCollision(player, collision));
                    }
                }

                foreach (IBlock block in room.Blocks)
                {
                    if (player.Footbox.Intersects(block.Hitbox))
                    {
                        collisions.Add(new PlayerBlockCollision(room.Doors, player, block));
                    }
                }

                foreach (KeyValuePair<string, IDoor> door in room.Doors.ToList())
                {
                    if (door.Value.Hitbox.Intersects(player.Footbox))
                    {
                        collisions.Add(new PlayerDoorCollision(room.Doors, door, player, game));
                    }
                }

                foreach (IEnemy enemy in room.Enemies)
                {
                    Rectangle collision = Rectangle.Intersect(enemy.Hitbox, player.Hitbox);
                    if (!collision.IsEmpty)
                    {
                        collisions.Add(new PlayerEnemyCollision(player, collision, enemy, game));
                    }
                }

                foreach (INPC npc in room.NPCs)
                {
                    Rectangle collision = Rectangle.Intersect(npc.Hitbox, player.Hitbox);
                    if (!collision.IsEmpty)
                    {
                        collisions.Add(new PlayerWallCollision(player, collision));
                    }
                }

                foreach (IProjectile projectile in projectileManager)
                {
                    Rectangle collision = Rectangle.Intersect(projectile.Hitbox, player.Hitbox);
                    if (!collision.IsEmpty)
                    {
                        collisions.Add(new PlayerProjectileCollision(projectileManager, player,
                                projectile, collision));
                    }

                    //Boomerang Item Pickup Code
                    if (projectile is BoomerangProjectile && projectile.OwningTeam == Team.Link)
                    {
                        for (int currentPosition = 0; currentPosition < room.Items.Count; currentPosition++)
                        {
                            IItem item = room.Items[currentPosition];
                            collision = Rectangle.Intersect(item.Hitbox, projectile.Hitbox);
                            if (!collision.IsEmpty)
                            {
                                collisions.Add(new ItemPlayerCollision(room.Items, player, item));
                            }
                        }
                    }
                }


                for (int currentPosition = 0; currentPosition < room.Items.Count; currentPosition++)
                {
                    IItem item = room.Items[currentPosition];
                    Rectangle collision = Rectangle.Intersect(item.Hitbox, player.Hitbox);
                    if (!collision.IsEmpty)
                    {
                        collisions.Add(new ItemPlayerCollision(room.Items, player, item));
                    }
                    if (item is IMovingItem)
                    {
                        foreach (Rectangle wall in room.Hitboxes)
                        {
                            collision = Rectangle.Intersect(item.Hitbox, wall);
                            if (!collision.IsEmpty)
                            {
                                collisions.Add(new ItemWallCollision(item as IMovingItem, collision));
                            }
                        }
                        foreach (IDoor door in room.Doors.Values)
                        {
                            collision = Rectangle.Intersect(item.Hitbox, door.Hitbox);
                            if (!collision.IsEmpty)
                            {
                                collisions.Add(new ItemWallCollision(item as IMovingItem, collision));
                            }
                        }
                        foreach (IBlock block in room.Blocks)
                        {
                            collision = Rectangle.Intersect(item.Hitbox, block.Hitbox);
                            if (!collision.IsEmpty)
                            {
                                collisions.Add(new ItemWallCollision(item as IMovingItem, collision));
                            }
                        }
                    }
                }
            }
        }

        private void HandleEnemyCollisions(IRoom room, IPlayer player)
        {
            if (!(player.State is GrabbedLinkState))
            {
                foreach (IEnemy enemy in room.Enemies)
                {
                    foreach (Rectangle wall in room.Hitboxes)
                    {
                        Rectangle collision = Rectangle.Intersect(wall, enemy.Hitbox);
                        if (!collision.IsEmpty && !(enemy is LFWallmaster || enemy is RFWallmaster))
                        {
                            collisions.Add(new EnemyWallBlockDoorCollision(enemy, collision));
                        }
                    }

                    foreach (KeyValuePair<string, IDoor> door in room.Doors)
                    {
                        Rectangle collision = Rectangle.Intersect(door.Value.Hitbox, enemy.Hitbox);
                        if (!collision.IsEmpty && !(enemy is LFWallmaster || enemy is RFWallmaster))
                        {
                            collisions.Add(new EnemyWallBlockDoorCollision(enemy, collision));
                        }
                    }

                    foreach (IBlock block in room.Blocks)
                    {
                        Rectangle collision = Rectangle.Intersect(block.Hitbox, enemy.Hitbox);
                        if (!collision.IsEmpty && !(enemy is Keese || enemy is LFWallmaster || enemy is RFWallmaster))
                        {
                            collisions.Add(new EnemyWallBlockDoorCollision(enemy, collision));
                        }
                    }

                    foreach (IProjectile projectile in projectileManager)
                    {
                        Rectangle collision = Rectangle.Intersect(projectile.Hitbox, enemy.Hitbox);
                        if (!collision.IsEmpty && !(enemy is Trap))
                        {
                            collisions.Add(new EnemyProjectileCollision(projectileManager, room.Enemies,
                                enemy, projectile, collision));
                        }
                    }


                    if (enemy.Hitbox.Intersects(player.LeftAttackBox))
                    {
                        collisions.Add(new EnemyAttackCollision(room.Enemies, enemy, player, "left"));
                    }
                    if (enemy.Hitbox.Intersects(player.UpAttackBox))
                    {
                        collisions.Add(new EnemyAttackCollision(room.Enemies, enemy, player, "up"));
                    }
                    if (enemy.Hitbox.Intersects(player.RightAttackBox))
                    {
                        collisions.Add(new EnemyAttackCollision(room.Enemies, enemy, player, "right"));
                    }
                    if (enemy.Hitbox.Intersects(player.DownAttackBox))
                    {
                        collisions.Add(new EnemyAttackCollision(room.Enemies, enemy, player, "down"));
                    }

                }

                foreach(INPC npc in room.NPCs)
                {
                    foreach (IProjectile projectile in projectileManager)
                    {
                        Rectangle collision = Rectangle.Intersect(projectile.Hitbox, npc.Hitbox);
                        if (!collision.IsEmpty)
                        {
                            if(npc is OldMan)
                            {
                                game.OldManDamaged = true;
                            }
                        }
                    }
                }
            }
        }

        private void HandleProjectileCollisions(IRoom room)
        {
            foreach (IProjectile projectile in projectileManager)
            {
                foreach (Rectangle wall in room.Hitboxes)
                {
                    Rectangle collision = Rectangle.Intersect(wall, projectile.Hitbox);
                    if (!collision.IsEmpty)
                    {
                        collisions.Add(new WallProjectileCollision(projectileManager, projectile, collision));
                    }
                }

                foreach (IDoor door in room.Doors.Values)
                {
                    Rectangle collision = Rectangle.Intersect(door.Hitbox, projectile.Hitbox);
                    if (!collision.IsEmpty)
                    {
                        collisions.Add(new WallProjectileCollision(projectileManager, projectile, collision));
                    }
                }

                // takes care of case where goriya dies b4 boomerang returns
                if ((projectile is BoomerangProjectile)
                    && (projectile as BoomerangProjectile).Returned)
                {
                    collisions.Add(new DummyProjectileCollision(projectileManager, projectile));
                }
                // get rid of bombs when they're done doing their things
                else if ((projectile is Explosion)
                    && (projectile as Explosion).Done)
                {
                    collisions.Add(new DummyProjectileCollision(projectileManager, projectile));
                }
                else if ((projectile is PlacedBomb)
                    && (projectile as PlacedBomb).Exploded)
                {
                    collisions.Add(new DummyProjectileCollision(projectileManager, projectile));
                }
            }
        }

    }

}

