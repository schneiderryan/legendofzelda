using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class TopKey : Door
    {

        public TopKey()
        {
            door = RoomSpriteFactory.Instance.CreateTopKey();
            door.Scale = 2.0f;
            door.Position = new Point(224, 0);
            Hitbox = door.Box;
        }


       
    }
}
