using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class Room : IRoom, ICollideableRoom
    {
        public LegendOfZelda game;
        public ISprite background;
        public Dictionary<String, IDoor> doors = new Dictionary<String, IDoor>();
        public List<IEnemy> enemies;
        public List<IItem> items;
        public List<IBlock> blocks;
        public List<Rectangle> boxes;
        private Rectangle hitboxLeft1;
        private Rectangle hitboxLeft2;
        private Rectangle hitboxTop1;
        private Rectangle hitboxTop2;
        private Rectangle hitboxBottom1;
        private Rectangle hitboxBottom2;
        private Rectangle hitboxRight1;
        private Rectangle hitboxRight2;

        private List<ICollision> collisions;

        public List<Rectangle> Hitboxes
        {
            get { return boxes; }
            protected set { boxes = value; }
        }
        //populate with items and enemies (and player?)
        public Room(LegendOfZelda game, String levelName)
        {
            this.game = game;

            LevelLoader levelLoader = new LevelLoader(levelName, game);

            this.background = levelLoader.loadBackground();
            this.background.Scale = 2.0f;
            this.background.Position = new Point(0, 0);

            this.enemies = levelLoader.loadEnemies();
            this.items = levelLoader.loadItems();
            this.blocks = levelLoader.loadBlocks();

           this.doors = levelLoader.loadDoors();
           
            boxes = new List<Rectangle>();


            hitboxLeft1 = new Rectangle(0, 0, 64, 144);
            hitboxLeft2 = new Rectangle(0, 209, 64, 144);
            boxes.Add(hitboxLeft1);
            boxes.Add(hitboxLeft2);

            hitboxTop1 = new Rectangle(0, 0, 224, 64);
            hitboxTop2 = new Rectangle(289, 0, 224, 64);
            boxes.Add(hitboxTop1);
            boxes.Add(hitboxTop2);

            hitboxBottom1 = new Rectangle(0, 289, 224, 64);
            hitboxBottom2 = new Rectangle(289, 289, 224, 64);
            boxes.Add(hitboxBottom1);
            boxes.Add(hitboxBottom2);

            hitboxRight1 = new Rectangle(448, 0, 64, 144);
            hitboxRight2 = new Rectangle(448, 209, 64, 144);
            boxes.Add(hitboxRight1);
            boxes.Add(hitboxRight2);

            collisions = new List<ICollision>();
        }

        public void DrawDoor(SpriteBatch sb, Color color)
        {
            foreach(KeyValuePair<String, IDoor> door in doors)
            {
               door.Value.Draw(sb, color);
            }
        }
        public void Draw(SpriteBatch sb, Color color)
        {
            background.Draw(sb);
            foreach (IEnemy enemy in enemies)
            {
                enemy.Draw(sb);
            }

            foreach (IItem item in items)
            {
                item.Draw(sb);
                Debug.DrawHitbox(sb, item.Hitbox);
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
            //state.Update();
            background.Update();

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

            foreach (IBlock block in blocks)
            {
                block.Update();
                if (game.link.Hitbox.Intersects(block.Hitbox))
                {
                    collisions.Add(new PlayerBlockCollision(game.link, block));
                }
            }

            foreach(ICollision collision in collisions)
            {
                collision.Handle();
            }
            collisions = new List<ICollision>();

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
        }
    }
}
