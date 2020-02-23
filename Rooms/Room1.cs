using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class Room1 : IRoom
    {
        public LegendOfZelda game;
        public ISprite sprite;
        public IRoomState state;
        public List<IEnemy> enemies;
        public List<IItem> items;
        private List<Rectangle> boxes;
        private Rectangle hitboxLeft1;
        private Rectangle hitboxLeft2;
        private Rectangle hitboxRight1;
        private Rectangle hitboxRight2;
        private Rectangle hitboxTop1;
        private Rectangle hitboxTop2;
        private Rectangle hitboxBottom1;
        private Rectangle hitboxBottom2;

        public List<Rectangle> Hitboxes
        {
            get
            {
             return boxes; 
            } 

            protected set { boxes = value; }
        }

        

        //populate with items and enemies (and player?)
        public Room1(LegendOfZelda game)
        {
           
            this.game = game;
            this.sprite = RoomSpriteFactory.Instance.CreateRoom1();
            
            this.sprite.Scale = 2.0f;
            
            this.sprite.Position = new Point(0, 0);
            this.state = new JustEnteredRoom1(this);

            LevelLoader levelLoader = new LevelLoader("Room1.csv", game);
            this.enemies = levelLoader.loadEnemies();
            this.items = levelLoader.loadItems();

            boxes = new List<Rectangle>();

            hitboxLeft1 = new Rectangle(0, 0, 64, 160);
            hitboxLeft2 = new Rectangle(0, 192, 64, 160);
            boxes.Add(hitboxLeft1);
            boxes.Add(hitboxLeft2);

            hitboxRight1 = new Rectangle(448, 0, 64, 160);
            hitboxRight2 = new Rectangle(448, 192, 64, 160);
            boxes.Add(hitboxRight1);
            boxes.Add(hitboxRight2);

            hitboxTop1 = new Rectangle(0, 0, 240, 64);
            hitboxTop2 = new Rectangle(272, 0, 240, 64);
            boxes.Add(hitboxTop1);
            boxes.Add(hitboxTop2);

            hitboxBottom1 = new Rectangle(0, 288, 240, 64);
            hitboxBottom2 = new Rectangle(272, 288, 240, 64);
            boxes.Add(hitboxBottom1);
            boxes.Add(hitboxBottom2);
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
        }
    }
}
