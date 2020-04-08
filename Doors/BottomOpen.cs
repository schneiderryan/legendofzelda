using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class BottomOpen : Door
    {
        
        public BottomOpen()
        {
            door = RoomSpriteFactory.Instance.CreateBottomOpen();
            door.Position = new Point(224, 288);
            Hitbox = new Rectangle((int)door.Scale / 2 * 241, (int)door.Scale / 2 * 351, (int)door.Scale / 2 * 30, (int)door.Scale / 2 * 1);

        }


    }
}
