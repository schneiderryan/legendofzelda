using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class LeftWall : Door
    {
       
        public LeftWall()
        {
            door = RoomSpriteFactory.Instance.CreateLeftWall();
            
            door.Position = new Point(0, 144);
            Hitbox = door.Box;
        }

       
    }
}
