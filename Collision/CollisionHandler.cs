using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;

namespace LegendOfZelda
{
    class CollisionHandler
    {
        private ISet<IProjectile> projectilesToDespawn;
        private ISet<IEnemy> enemiesToDespawn;
        private SortedList<IItem, int> itemsToDespawn;
        private List<int> itemsToDespawnPositions;

        private PlayerWallCollision playerWallCollision;
        private PlayerDoorCollision playerDoorCollision;
        private PlayerBlockCollision playerBlockCollision;
        private PlayerEnemyCollision playerEnemyCollision;
        private PlayerProjectileCollision playerProjectileCollision;
        private ItemCollision itemCollision;

        private EnemyWallBlockDoorCollision enemyWallBlockDoorCollision;
        private EnemyProjectileCollision enemyProjectileCollision;

        private WallProjectileCollision wallProjectileCollision;

        private IList<IDespawnEffect> effects;

        private int currentPosition;
        public bool playerTouchingBlockorWall;
        public bool enemyTouchingBlockorWall;

        public CollisionHandler(IList<IDespawnEffect> effects)
        {
            projectilesToDespawn = new HashSet<IProjectile>();
            enemiesToDespawn = new HashSet<IEnemy>();
            itemsToDespawn = new SortedList<IItem, int>();
            itemsToDespawnPositions = new List<int>();

            playerDoorCollision = new PlayerDoorCollision();
            playerWallCollision = new PlayerWallCollision();
            playerBlockCollision = new PlayerBlockCollision();
            itemCollision = new ItemCollision(itemsToDespawnPositions);
            playerEnemyCollision = new PlayerEnemyCollision(enemiesToDespawn, this);
            playerProjectileCollision = new PlayerProjectileCollision(projectilesToDespawn, this);

            enemyWallBlockDoorCollision = new EnemyWallBlockDoorCollision();
            enemyProjectileCollision = new EnemyProjectileCollision(projectilesToDespawn, enemiesToDespawn, this);

            wallProjectileCollision = new WallProjectileCollision(projectilesToDespawn);

            this.effects = effects;
            currentPosition= 0;
        }

        public void Handle(IRoom room, ISet<IProjectile> projectiles, IPlayer player)
        {
            // check if player and enemies are touching walls and blocks
            CheckPlayerTouchingWallBlock(player, room);
            CheckEnemyTouchingWallBlock(room);

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

            foreach (IDoor door in room.Doors.Values)
            {
                Rectangle collision = Rectangle.Intersect(door.Hitbox, player.Footbox);
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

            foreach (KeyValuePair<string, IDoor> door in room.Doors.ToList())
            {
                Rectangle collision = Rectangle.Intersect(door.Value.Hitbox, player.Footbox);
                if (!collision.IsEmpty)
                {
                    if(!(door.Value is TopOpen || door.Value is BottomOpen || door.Value is LeftOpen || door.Value is RightOpen)){
                        if (door.Value is TopKey)
                        {
                            room.Doors.Remove(door);
                            room.Doors.Add("top", new TopOpen());
                        }
                        playerDoorCollision.Handle(player, door.Value, collision);
                    }
                    
                }
            }

            foreach (IEnemy enemy in room.Enemies)
            {
                Rectangle collision = Rectangle.Intersect(enemy.Hitbox, player.Hitbox);
                if (!collision.IsEmpty && !(enemy is Trap))
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
                    if (!collision.IsEmpty && !(enemy is LFWallmaster || enemy is RFWallmaster))
                    {
                        enemyWallBlockDoorCollision.Handle(enemy, collision);
                    }
                }

                foreach (KeyValuePair<string, IDoor> door in room.Doors)
                {
                    Rectangle collision = Rectangle.Intersect(door.Value.Hitbox, enemy.Hitbox);
                    if (!collision.IsEmpty)
                    {
                            enemyWallBlockDoorCollision.Handle(enemy, collision);
                    }
                }

                foreach (IDoor door in room.Doors.Values)
                {
                    Rectangle collision = Rectangle.Intersect(door.Hitbox, enemy.Hitbox);
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
                        if(!(enemy is Keese)){
                           enemyWallBlockDoorCollision.Handle(enemy, collision);
                        }
                           
                    }
                }

                foreach (IProjectile projectile in projectiles)
                {
                    Rectangle collision = Rectangle.Intersect(projectile.Hitbox, enemy.Hitbox);
                    if (!collision.IsEmpty && !(enemy is Trap))
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

        private void CheckPlayerTouchingWallBlock(IPlayer player, IRoom room)
        {
            this.playerTouchingBlockorWall = false;
            foreach(IBlock block in room.Blocks)
            {
                Rectangle collision = Rectangle.Intersect(player.Footbox, block.Hitbox);
                if (!collision.IsEmpty)
                {
                    playerTouchingBlockorWall = true;
                }
            }
            foreach (Rectangle wall in room.Hitboxes)
            {
                Rectangle collision = Rectangle.Intersect(player.Footbox, wall);
                if (!collision.IsEmpty)
                {
                    playerTouchingBlockorWall = true;
                }
            }
        }

        private void CheckEnemyTouchingWallBlock(IRoom room)
        {
            this.enemyTouchingBlockorWall = false;
            foreach (IEnemy enemy in room.Enemies)
            {
                if (this.enemyTouchingBlockorWall == true)
                {
                    foreach (IBlock block in room.Blocks)
                    {
                        Rectangle collision = Rectangle.Intersect(enemy.Hitbox, block.Hitbox);
                        if (!collision.IsEmpty)
                        {
                            enemyTouchingBlockorWall = true;
                        }
                    }
                    foreach (Rectangle wall in room.Hitboxes)
                    {
                        Rectangle collision = Rectangle.Intersect(enemy.Hitbox, wall);
                        if (!collision.IsEmpty)
                        {
                            enemyTouchingBlockorWall = true;
                        }
                    }
                }
            }
            
        }

    }
}
