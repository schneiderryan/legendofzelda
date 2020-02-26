using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class RightKey : Door
    {
       
        public RightKey()
        {
            door = RoomSpriteFactory.Instance.CreateRightKey();
            door.Scale = 2.0f;
            door.Position = new Point(448, 144);
            Hitbox = door.Box;
        }


        
    }
}
