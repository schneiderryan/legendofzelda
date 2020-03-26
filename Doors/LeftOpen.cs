using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class LeftOpen : Door
    {
       

        public LeftOpen()
        {
            door = RoomSpriteFactory.Instance.CreateLeftOpen();
            door.Position = new Point(0, 144);
            Hitbox = new Rectangle(0, 163, 1, 30);

        }

    }



}

