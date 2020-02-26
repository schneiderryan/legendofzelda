using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class BottomOther : Door
    {
       
        public BottomOther()
        {
            door = RoomSpriteFactory.Instance.CreateBottomOther();
            door.Scale = 2.0f;
            door.Position = new Point(225, 288);
            Hitbox = door.Box;
        }


       
    }
}
