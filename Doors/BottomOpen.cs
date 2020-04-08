using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class BottomOpen : Door
    {
        
        public BottomOpen()
        {
            door = RoomSpriteFactory.Instance.CreateBottomOpen();
            door.Position = new Point(224, 288);
            Hitbox = door.Box;

        }


    }
}
