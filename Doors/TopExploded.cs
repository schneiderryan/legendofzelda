using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class TopExploded : Door
    {
        

        public TopExploded()
        {
            door = RoomSpriteFactory.Instance.CreateTopExploded();
            door.Position = new Point(225, 0);
            Hitbox = door.Box;
            
        }


    }
}
