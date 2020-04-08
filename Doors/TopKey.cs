using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class TopKey : Door
    {

        public TopKey()
        {
            door = RoomSpriteFactory.Instance.CreateTopKey();
            door.Position = new Point(224, 0);
            Hitbox = door.Box;
        }


       
    }
}
