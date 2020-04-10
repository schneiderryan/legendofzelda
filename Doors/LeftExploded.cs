using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class LeftExploded : Door
    {
        
        public LeftExploded()
        {
            door = RoomSpriteFactory.Instance.CreateLeftExploded();
            door.Position = new Point(0, 264);
            Hitbox = door.Box;
        }


       
    }
}
