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

        //populate with items and enemies (and player?)
        public Room1(LegendOfZelda game)
        {
            this.game = game;
            this.sprite = RoomSpriteFactory.Instance.CreateRoom0();
            
            this.sprite.Scale = 2.0f;
            
            this.sprite.Position = new Point(0, 0);
            this.state = new JustEnteredRoom1(this);

            LevelLoader levelLoader = new LevelLoader("Room1.csv", game);
            this.enemies = levelLoader.loadEnemies();
            this.items = levelLoader.loadItems();
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
