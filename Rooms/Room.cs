using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class Room : IRoom
    {
        public LegendOfZelda game;
        public ISprite background;
        public Dictionary<String, IDoor> doors = new Dictionary<String, IDoor>();
        public List<IEnemy> enemies;
        public List<IItem> items;
        public List<IProjectile> projectiles;

        private Rectangle hitboxLeft1;
        private Rectangle hitboxLeft2;
        private Rectangle hitboxTop1;
        private Rectangle hitboxTop2;
        private Rectangle hitboxBottom1;
        private Rectangle hitboxBottom2;
        private Rectangle hitboxRight1;
        private Rectangle hitboxRight2;

        public List<IBlock> blocks;
        public List<IMoveableBlock> moveableBlocks;
       
        public List<Rectangle> hitboxes;

        //populate with items and enemies (and player?)
        public Room(LegendOfZelda game, String levelName)
        {
            this.game = game;

            LevelLoader levelLoader = new LevelLoader(levelName, game);

            this.background = levelLoader.LoadBackground();
            this.background.Scale = 2.0f;
            this.background.Position = new Point(0, 0);

            this.enemies = levelLoader.LoadEnemies();
            this.items = levelLoader.LoadItems();
            this.projectiles = new List<IProjectile>();
            this.moveableBlocks = levelLoader.LoadMoveableBlocks();
            this.blocks = levelLoader.LoadStillBlocks();
            this.blocks.AddRange(moveableBlocks);

            this.doors = levelLoader.LoadDoors();
            foreach (KeyValuePair<String, IDoor> door in this.doors)
            {
                if (door.Key == "right")
                {
                    if (door.Value is RightOpen)
                    {
                        hitboxRight1 = new Rectangle(448, 0, 64, 154);
                        hitboxRight2 = new Rectangle(448, 199, 64, 144);
                    }
                    else
                    {
                        hitboxRight1 = new Rectangle(448, 0, 64, 144);
                        hitboxRight2 = new Rectangle(448, 209, 64, 144);
                    }
                }

                if (door.Key == "left")
                {
                    if (door.Value is LeftOpen)
                    {
                        hitboxLeft1 = new Rectangle(0, 0, 64, 144);
                        hitboxLeft2 = new Rectangle(0, 209, 64, 144);
                    }
                    else
                    {
                        hitboxLeft1 = new Rectangle(0, 0, 64, 144);
                        hitboxLeft2 = new Rectangle(0, 209, 64, 144);
                    }
                }

                if (door.Key == "up")
                {
                    if (door.Value is TopOpen)
                    {
                        hitboxTop1 = new Rectangle(0, 0, 224, 64);
                        hitboxTop2 = new Rectangle(289, 0, 224, 64);
                    }
                    else
                    {
                        hitboxTop1 = new Rectangle(0, 0, 224, 64);
                        hitboxTop2 = new Rectangle(289, 0, 224, 64);
                    }

                }
                if (door.Key == "down")
                {
                    if (door.Value is BottomOpen)
                    {
                        hitboxBottom1 = new Rectangle(0, 289, 224, 64);
                        hitboxBottom2 = new Rectangle(289, 289, 224, 64);
                    }
                    else
                    {
                        hitboxBottom1 = new Rectangle(0, 289, 224, 64);
                        hitboxBottom2 = new Rectangle(289, 289, 224, 64);
                    }

                }



            }
            

            hitboxes = new List<Rectangle>();

            
            hitboxes.Add(hitboxLeft1);
            hitboxes.Add(hitboxLeft2);

            
            hitboxes.Add(hitboxTop1);
            hitboxes.Add(hitboxTop2);

           
            hitboxes.Add(hitboxBottom1);
            hitboxes.Add(hitboxBottom2);

            
            hitboxes.Add(hitboxRight1);
            hitboxes.Add(hitboxRight2);
        }

        public Dictionary<String, IDoor> getDoor()
        {
            return doors;
        }

        public void DrawOverlay(SpriteBatch sb)
        {
            // draw door frames?
        }

        public void Draw(SpriteBatch sb)
        {
            background.Draw(sb);

            foreach (KeyValuePair<String, IDoor> door in doors)
            {
                door.Value.Draw(sb);
                Debug.DrawHitbox(sb, door.Value.Hitbox);
            }

            foreach (IBlock b in blocks)
            {
                Debug.DrawHitbox(sb, b.Hitbox);
            }

            foreach (IMoveableBlock b in moveableBlocks)
            {
                b.Draw(sb);
                Debug.DrawHitbox(sb, b.Hitbox);
            }

            foreach (IItem item in items)
            {
                item.Draw(sb);
                Debug.DrawHitbox(sb, item.Hitbox);
            }

            foreach (IEnemy enemy in enemies)
            {
                enemy.Draw(sb);
                Debug.DrawHitbox(sb, enemy.Hitbox);
            }

            foreach (IProjectile projectile in projectiles)
            {
                projectile.Draw(sb);
                Debug.DrawHitbox(sb, projectile.Hitbox);
            }

            foreach (Rectangle box in hitboxes)
            {
                Debug.DrawHitbox(sb, box);
            }
        }

        public void Update()
        {
            foreach (KeyValuePair<String, IDoor> door in doors)
            {
                door.Value.Update();
            }

            foreach (IItem item in items)
            {
                item.Update();
            }

            foreach (IEnemy enemy in enemies)
            {
                enemy.Update();
            }
            foreach (IMoveableBlock b in moveableBlocks)
            {
                b.Update();
            }

            foreach (IProjectile projectile in projectiles)
            {
                projectile.Update();
            }

            // collision stuffs
            foreach (IItem item in items)
            {
                // check collision
                // if intersects then
                // Item.Pickup(IPlayer) ?
            }

            foreach (IProjectile p in projectiles)
            {
                if (p.Hitbox.Intersects(game.link.Hitbox))
                {
                    // do things
                }
            }

            // order matters, for the blocks and moveable blocks at least
            PlayerCollisionDetector.HandlePlayerCollisions(game.link, this);
            EnemyCollisionDetector.HandleEnemyCollisions(this, game.link);
        }
    }
}
