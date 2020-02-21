using LegendOfZelda;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class JustEnteredRoom0 : IRoomState
    {
        private Room0 room;

        public JustEnteredRoom0(Room0 room)
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
