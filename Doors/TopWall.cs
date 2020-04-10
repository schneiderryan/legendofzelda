using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class TopWall : Door
    {
       
        public TopWall()
        {
            door = RoomSpriteFactory.Instance.CreateTopWall();
            door.Position = new Point(224, 120);
            Hitbox = door.Box;
        }


       
    }
}
