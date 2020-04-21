﻿using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class LeftPortal : Door
    {
       
        public LeftPortal()
        {
            door = RoomSpriteFactory.Instance.CreateLeftOpen();
            door.Position = new Point(0, 264);
            Hitbox = new Rectangle(0, 283, 1, 30);

        }

    }



}

