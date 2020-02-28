using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class Room : IRoom
    {
        public Dictionary<String, IDoor> doors = new Dictionary<String, IDoor>();
        public List<Rectangle> hitboxes;
        public List<IBlock> blocks;
        public List<IMoveableBlock> moveableBlocks;

        private List<IItem> items;
        private List<IEnemy> enemies;
        private LegendOfZelda game;
        private ISprite background;

        public Room(LegendOfZelda game, String levelName)
        {
            this.game = game;

            LevelLoader levelLoader = new LevelLoader(levelName, game);

            this.background = levelLoader.LoadBackground();
            this.background.Scale = 2.0f;
            this.background.Position = new Point(0, 0);

            this.enemies = levelLoader.LoadEnemies();
            this.items = levelLoader.LoadItems();
            this.moveableBlocks = levelLoader.LoadMoveableBlocks();
            this.blocks = levelLoader.LoadStillBlocks();
            this.blocks.AddRange(moveableBlocks);

            this.doors = levelLoader.LoadDoors();

            hitboxes = new List<Rectangle>()
            {
                // left hitboxes
                new Rectangle(0, 0, 64, 144),
                new Rectangle(0, 209, 64, 144),

                // top hitboxes
                new Rectangle(0, 0, 224, 64),
                new Rectangle(289, 0, 224, 64),

                // bottom hitboxes
                new Rectangle(0, 289, 224, 64),
                new Rectangle(289, 289, 224, 64),

                // right hitboxes
                new Rectangle(448, 0, 64, 144),
                new Rectangle(448, 209, 64, 144),
            };
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

            foreach (IItem item in items)
            {
                // check collision
                // if intersects then
                // Item.Pickup(IPlayer) ?
            }

            PlayerCollisionHandler.HandlePlayerCollisions(game.link, this);
            EnemyCollisionDetector.HandleEnemyCollisions(enemies, this, game.link);
        }
    }
}
