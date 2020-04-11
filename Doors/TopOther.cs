using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class TopOther : Door
    {
      
        public TopOther()
        {
            door = RoomSpriteFactory.Instance.CreateTopOther();

            door.Position = new Point(225, 120);

        }


       
    }
}
