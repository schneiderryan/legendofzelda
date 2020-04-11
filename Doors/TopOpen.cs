﻿using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class TopOpen : Door
    {
        
        public TopOpen()
        {
            door = RoomSpriteFactory.Instance.CreateTopOpen();

            door.Position = new Point(225, 120);
            Hitbox = new Rectangle(241, 137, 30, 1);

        }


       
    }
}
