using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class LeftKey : Door
    {
       
        public LeftKey()
        {
            door = RoomSpriteFactory.Instance.CreateLeftKey();
            door.Position = new Point(0, 264);
            Hitbox = door.Box;
        }


    }
}
