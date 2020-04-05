using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class BottomWall : Door
    {
       
        public BottomWall()
        {
            door = RoomSpriteFactory.Instance.CreateBottomWall();
            door.Position = new Point(224, 288);
            Hitbox = door.Box;
        }


    
    }
}
