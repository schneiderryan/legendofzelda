﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class BottomOpen : Door
    {
        
        public BottomOpen()
        {
            door = RoomSpriteFactory.Instance.CreateBottomOpen();
           
            door.Position = new Point(225, 288);
            Hitbox = new Rectangle(241, 351, 30, 1);
        }


    }
}
