using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class LeftExploded : Door
    {
        
        public LeftExploded()
        {
            door = RoomSpriteFactory.Instance.CreateLeftExploded();
            door.Position = new Point(0, 145);
            Hitbox = door.Box;
        }


       
    }
}
