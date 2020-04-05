using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class RightExploded : Door
    {
        
        public RightExploded()
        {
            door = RoomSpriteFactory.Instance.CreateRightExploded();
            door.Position = new Point(448, 145);
            Hitbox = door.Box;
        }


        
    }
}
