using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class BottomOpen : Door
    {
        
        public BottomOpen()
        {
            door = RoomSpriteFactory.Instance.CreateBottomOpen();
            door.Position = new Point(224, 408);
            Hitbox = door.Box;

        }


    }
}
