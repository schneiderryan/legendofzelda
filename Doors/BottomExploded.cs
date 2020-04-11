using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class BottomExploded : Door
    {
        
        public BottomExploded()
        {
            door = RoomSpriteFactory.Instance.CreateBottomExploded();
            door.Position = new Point(224, 408);
            Hitbox = door.Box;
            
        }


    }
}
