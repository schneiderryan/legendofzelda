using Microsoft.Xna.Framework;


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

