using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class RightOther : Door
    {
       
        public RightOther()
        {
            door = RoomSpriteFactory.Instance.CreateRightOther();
            door.Position = new Point(448, 145);
            Hitbox = door.Box;
        }


        
    }
}
