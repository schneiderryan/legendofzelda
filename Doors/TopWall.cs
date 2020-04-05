using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class TopWall : Door
    {
       
        public TopWall()
        {
            door = RoomSpriteFactory.Instance.CreateTopWall();
            door.Position = new Point(224, 0);
            Hitbox = door.Box;
        }


       
    }
}
