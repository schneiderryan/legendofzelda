using LegendOfZelda;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class JustEnteredRoom1 : IRoomState
    {
        private Room1 room;

        public JustEnteredRoom1(Room1 room)
        {
            this.room = room;
            //more logic
        }
        public void EnterRoomAbove()
        {
            throw new NotImplementedException();
        }

        public void EnterRoomBelow()
        {
            throw new NotImplementedException();
        }

        public void EnterRoomLeft()
        {
            throw new NotImplementedException();
        }

        public void EnterRoomRight()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            room.sprite.Position = new Point(0, 0);
        }
    }
}
