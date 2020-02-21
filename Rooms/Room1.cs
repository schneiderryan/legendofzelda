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

        //populate with items and enemies (and player?)
        public Room1(LegendOfZelda game)
        {
            this.game = game;
            this.sprite = RoomSpriteFactory.Instance.CreateRoom1();
            
            this.sprite.Scale = 2.0f;
            
            this.sprite.Position = new Point(0, 0);
            this.state = new JustEnteredRoom1(this);
           
        }

        public void Draw(SpriteBatch sb, Color color)
        {
            sprite.Draw(sb, color);
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
        }
    }
}
