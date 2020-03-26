using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class RightOpen : Door
    {
       
        public RightOpen()
        {
            door = RoomSpriteFactory.Instance.CreateRightOpen();
            door.Position = new Point(448, 144);
            Hitbox = new Rectangle(511, 163, 1, 30);
        }


        
    }
}
