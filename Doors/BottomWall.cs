using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class BottomWall : Door
    {
       
        public BottomWall()
        {
            door = RoomSpriteFactory.Instance.CreateBottomWall();
            door.Position = new Point(224, 408);
            Hitbox = door.Box;
        }


    
    }
}
