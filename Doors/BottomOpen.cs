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
           
            door.Position = new Point((int)door.Scale/2*225, (int)door.Scale/2 * 288);
            Hitbox = new Rectangle((int)door.Scale/2 * 241, (int)door.Scale/2 * 351, (int)door.Scale/2 * 30, (int)door.Scale/2 * 1);
        }


    }
}
