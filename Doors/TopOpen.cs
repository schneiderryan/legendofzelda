using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class TopOpen : Door
    {
        
        public TopOpen()
        {
            door = RoomSpriteFactory.Instance.CreateTopOpen();
            door.Scale = 2.0f;
            door.Position = new Point(225, 0);
            //Hitbox = door.Box;
        }


       
    }
}
