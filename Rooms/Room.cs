using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class Room : IRoom
    {
        public IDictionary<string, IDoor> Doors { get; private set; }
        public IList<Rectangle> Hitboxes { get; private set; }
        public IList<IBlock> Blocks { get => blocks; }
        public IList<IMoveableBlock> MoveableBlocks { get; private set; }
        public IList<IEnemy> Enemies { get; private set; }

        private List<IBlock> blocks;
        private IList<IItem> items;
        private LegendOfZelda game;
        private ISprite background;

        public Room(LegendOfZelda game, String levelName)
        {
            this.game = game;

            LevelLoader levelLoader = new LevelLoader(levelName, game);

            this.background = levelLoader.LoadBackground();
            this.background.Scale = 2.0f;
            this.background.Position = new Point(0, 0);

            this.Enemies = levelLoader.LoadEnemies();
            this.items = levelLoader.LoadItems();
            this.MoveableBlocks = levelLoader.LoadMoveableBlocks();
            this.blocks = levelLoader.LoadStillBlocks();
            this.blocks.AddRange(MoveableBlocks);
            

            this.Doors = levelLoader.LoadDoors();

            Hitboxes = new List<Rectangle>()
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

        public IDictionary<string, IDoor> getDoor()
        {
            return Doors;
        }

        public void DrawOverlay(SpriteBatch sb)
        {
            // draw door frames?
        }

        public void Draw(SpriteBatch sb)
        {
            background.Draw(sb);

            foreach (KeyValuePair<String, IDoor> door in Doors)
            {
                door.Value.Draw(sb);
                Debug.DrawHitbox(sb, door.Value.Hitbox);
            }

            foreach (IBlock b in Blocks)
            {
                Debug.DrawHitbox(sb, b.Hitbox);
            }

            foreach (IMoveableBlock b in MoveableBlocks)
            {
                b.Draw(sb);
                Debug.DrawHitbox(sb, b.Hitbox);
            }

            foreach (IItem item in items)
            {
                item.Draw(sb);
                Debug.DrawHitbox(sb, item.Hitbox);
            }

            foreach (IEnemy enemy in Enemies)
            {
                enemy.Draw(sb);
                Debug.DrawHitbox(sb, enemy.Hitbox);
            }

            foreach (Rectangle box in Hitboxes)
            {
                Debug.DrawHitbox(sb, box);
            }
        }

        public void Update()
        {
            foreach (KeyValuePair<String, IDoor> door in Doors)
            {
                door.Value.Update();
            }
            foreach (IMoveableBlock b in MoveableBlocks)
            {
                b.Update();
            }

            foreach (IItem item in items)
            {
                item.Update();
            }
            foreach (IEnemy enemy in Enemies)
            {
                enemy.Update();
            }

            foreach (IItem item in items)
            {
                // check collision
                // if intersects then
                // Item.Pickup(IPlayer) ?
            }

            PlayerCollisionDetector.HandlePlayerCollisions(this, game.link);
            EnemyCollisionDetector.HandleEnemyCollisions(this);
        }
    }
}
