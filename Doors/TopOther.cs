using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class TopOther : Door
    {
      
        public TopOther()
        {
            door = RoomSpriteFactory.Instance.CreateTopOther();
            door.Scale = 2.0f;
            door.Position = new Point(225, 0);
            Hitbox = door.Box;
        }


       
    }
}
