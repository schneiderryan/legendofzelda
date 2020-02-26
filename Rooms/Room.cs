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

        private Rectangle hitboxLeft1;
        private Rectangle hitboxLeft2;
        private Rectangle hitboxTop1;
        private Rectangle hitboxTop2;
        private Rectangle hitboxBottom1;
        private Rectangle hitboxBottom2;
        private Rectangle hitboxRight1;
        private Rectangle hitboxRight2;

        public List<IBlock> blocks;
        private List<IMoveableBlock> moveableBlocks;
       
        public List<Rectangle> hitboxes;

        public Rectangle Hitbox => throw new NotImplementedException();

        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


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
            this.blocks = levelLoader.LoadStillBlocks();
            this.moveableBlocks = levelLoader.LoadMoveableBlocks();

            this.doors = levelLoader.LoadDoors();

            hitboxes = new List<Rectangle>();

            hitboxLeft1 = new Rectangle(0, 0, 64, 144);
            hitboxLeft2 = new Rectangle(0, 209, 64, 144);
            hitboxes.Add(hitboxLeft1);
            hitboxes.Add(hitboxLeft2);

            hitboxTop1 = new Rectangle(0, 0, 224, 64);
            hitboxTop2 = new Rectangle(289, 0, 224, 64);
            hitboxes.Add(hitboxTop1);
            hitboxes.Add(hitboxTop2);

            hitboxBottom1 = new Rectangle(0, 289, 224, 64);
            hitboxBottom2 = new Rectangle(289, 289, 224, 64);
            hitboxes.Add(hitboxBottom1);
            hitboxes.Add(hitboxBottom2);

            hitboxRight1 = new Rectangle(448, 0, 64, 144);
            hitboxRight2 = new Rectangle(448, 209, 64, 144);
            hitboxes.Add(hitboxRight1);
            hitboxes.Add(hitboxRight2);

        }


        public Dictionary<String, IDoor> getDoor()
        {
            return doors;
    }
        public void DrawDoor(SpriteBatch sb, Color color)
        {
            foreach(KeyValuePair<String, IDoor> door in doors)
            {
                door.Value.Draw(sb);
                Debug.DrawHitbox(sb, door.Value.Hitbox);
            }
        }
        public void Draw(SpriteBatch sb, Color color)
        {
            background.Draw(sb);
            foreach (IEnemy enemy in enemies)
            {
                enemy.Draw(sb);
                Debug.DrawHitbox(sb, enemy.Hitbox);
            }

            

            foreach (IItem item in items)
            {
                item.Draw(sb);
                Debug.DrawHitbox(sb, item.Hitbox);
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

            foreach (Rectangle box in hitboxes)
            {
                Debug.DrawHitbox(sb, box);
            }

        }

        public void EnterRoomAbove()
        {
            //state.EnterRoomAbove();
        }

        public void EnterRoomBelow()
        {
            //state.EnterRoomBelow();
        }

        public void EnterRoomLeft()
        {
            //state.EnterRoomLeft();
        }

        public void EnterRoomRight()
        {
            //state.EnterRoomRight();
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

            // collision stuffs
            foreach (IItem item in items)
            {
                // check collision
                // if intersects then
                // Item.Pickup(IPlayer) ?
            }

            foreach (IEnemy enemy in enemies)
            {
                // check collision
                // if intersects then
                // do things
            }
            CollisionHandler.PlayerWallCollision(game.link, this);
            CollisionHandler.PlayerDoorCollision(game.link, doors);
            CollisionHandler.PlayerBlockCollision(game.link, blocks);
            CollisionHandler.PlayerMoveableBlockCollision(game.link, moveableBlocks);
            EnemyCollisionDetector.HandleEnemyCollisions(enemies, this, this.game.link);
        }
    }
}
