﻿using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class LeftOpen : Door
    {
       
        public LeftOpen()
        {
            door = RoomSpriteFactory.Instance.CreateLeftOpen();
            door.Position = new Point(0, 264);
            Hitbox = door.Box;

        }

    }



}

