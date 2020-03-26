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
            door.Position = new Point(225, 0);
            Hitbox = new Rectangle(241, 17, 30, 1);
        }


       
    }
}
