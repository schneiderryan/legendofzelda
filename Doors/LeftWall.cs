using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class LeftWall : Door
    {
       
        public LeftWall()
        {
            door = RoomSpriteFactory.Instance.CreateLeftWall();
            door.Position = new Point(0, 264);

            Hitbox = door.Box;
        }

       
    }
}
