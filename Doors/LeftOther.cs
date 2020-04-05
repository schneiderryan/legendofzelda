using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class LeftOther : Door
    {
       
        public LeftOther()
        {
            door = RoomSpriteFactory.Instance.CreateLeftOther();
            door.Position = new Point(0, 145);
            Hitbox = door.Box;
        }

    }
}
