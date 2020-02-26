using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class BottomOpen : Door
    {
        
        public BottomOpen()
        {
            door = RoomSpriteFactory.Instance.CreateBottomOpen();
            door.Scale = 2.0f;
            door.Position = new Point(225, 288);
            Hitbox = door.Box;
        }


    }
}
