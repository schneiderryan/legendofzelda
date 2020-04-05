using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class TopOther : Door
    {
      
        public TopOther()
        {
            door = RoomSpriteFactory.Instance.CreateTopOther();
            door.Scale = 2.0f;
            door.Position = new Point(224, 0);
            Hitbox = door.Box;
        }


       
    }
}
