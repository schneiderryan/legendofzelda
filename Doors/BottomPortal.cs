using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class BottomPortal : Door
    {
        
        public BottomPortal()
        {
            door = RoomSpriteFactory.Instance.CreateBottomOpen();
            door.Position = new Point(224, 408);
            Hitbox = door.Box;
            
        }


    }
}
