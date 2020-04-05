using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class TopExploded : Door
    {
        

        public TopExploded()
        {
            door = RoomSpriteFactory.Instance.CreateTopExploded();
            door.Position = new Point(224, 0);
            Hitbox = door.Box;
            
        }


    }
}
