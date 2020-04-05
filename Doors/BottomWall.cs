using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class BottomWall : Door
    {
       
        public BottomWall()
        {
            door = RoomSpriteFactory.Instance.CreateBottomWall();
            door.Scale = 2.0f;
            door.Position = new Point(224, 288);
            Hitbox = door.Box;
        }


    
    }
}
