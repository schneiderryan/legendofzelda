using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class LeftWall : Door
    {
       
        public LeftWall()
        {
            door = RoomSpriteFactory.Instance.CreateLeftWall();
            door.Scale = 2.0f;
            door.Position = new Point(0, 145);
            Hitbox = door.Box;
        }

       
    }
}
