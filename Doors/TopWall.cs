using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class TopWall : Door
    {
       
        public TopWall()
        {
            door = RoomSpriteFactory.Instance.CreateTopWall();
            door.Scale = 2.0f;
            door.Position = new Point(224, 0);
            Hitbox = door.Box;
        }


       
    }
}
