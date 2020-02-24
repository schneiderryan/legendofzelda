using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class Room0 : IRoom, ICollideableRoom
    {
        public LegendOfZelda game;
        public ISprite sprite;
        public IRoomState state;
        public List<IEnemy> enemies;
        public List<IItem> items;
        public List<Rectangle> boxes;
        public List<IBlock> blocks;
        public List<IBlock> moveableBlocks;
        private Rectangle hitboxLeft;
        private Rectangle hitboxTop;
        private Rectangle hitboxBottom;
        private Rectangle hitboxRight1;
        private Rectangle hitboxRight2;


        public List<Rectangle> Hitboxes
        {
            get { return boxes; }
            protected set { boxes = value; }
        }
        //populate with items and enemies (and player?)
        public Room0(LegendOfZelda game)
        {
            this.game = game;
            this.sprite = RoomSpriteFactory.Instance.CreateRoom0();
            
            this.sprite.Scale = 2.0f;
            
            this.sprite.Position = new Point(0, 0);
            this.state = new JustEnteredRoom0(this);

            LevelLoader levelLoader = new LevelLoader("Room0.csv", game);
            this.enemies = levelLoader.loadEnemies();
            this.items = levelLoader.loadItems();
            this.blocks = levelLoader.loadStillBlocks();
            this.moveableBlocks = levelLoader.loadMoveableBlocks();

            boxes = new List<Rectangle>();
            
            
            
            
            hitboxLeft = new Rectangle(0, 0, 64, 352);
            boxes.Add(hitboxLeft);

            hitboxTop = new Rectangle(0, 0, 512, 64);
            boxes.Add(hitboxTop);

            hitboxBottom = new Rectangle(0, 288, 512, 64);
            boxes.Add(hitboxBottom);

            hitboxRight1 = new Rectangle(448, 0, 64, 160);
            hitboxRight2 = new Rectangle(448, 192, 64, 160);
            boxes.Add(hitboxRight1);
            boxes.Add(hitboxRight2);
        }

        
        public void Draw(SpriteBatch sb, Color color)
        {
            sprite.Draw(sb, color);

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
            state.EnterRoomAbove();
        }

        public void EnterRoomBelow()
        {
            state.EnterRoomBelow();
        }

        public void EnterRoomLeft()
        {
            state.EnterRoomLeft();
        }

        public void EnterRoomRight()
        {
            state.EnterRoomRight();
        }

        public void Update()
        {
            state.Update();
            sprite.Update();

            foreach (IItem item in items)
            {
                item.Update();
            }

            foreach(IEnemy enemy in enemies)
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

            CollisionHandler.HandlePlayerBlockCollision(game.link, blocks);
            CollisionHandler.HandlePlayerBlockCollision
        }
    }
}
