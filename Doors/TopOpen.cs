using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class TopOpen : Door
    {
        
        public TopOpen()
        {
            door = RoomSpriteFactory.Instance.CreateTopOpen();
            door.Scale = 2.0f;
            door.Position = new Point(224, 0);
            Hitbox = door.Box;
        }


       
    }
}
