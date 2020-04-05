using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class LeftKey : Door
    {
       
        public LeftKey()
        {
            door = RoomSpriteFactory.Instance.CreateLeftKey();
            door.Position = new Point(0, 144);
        }


    }
}
