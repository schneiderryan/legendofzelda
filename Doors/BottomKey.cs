using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class BottomKey : Door
    {
        
        public BottomKey()
        {
            door = RoomSpriteFactory.Instance.CreateBottomKey();
            door.Scale = 2.0f;
            door.Position = new Point(224, 288);
            Hitbox = door.Box;
        }


    }
}
