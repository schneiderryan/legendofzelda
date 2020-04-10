using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class RightWall : Door
    {
        
        public RightWall()
        {
            door = RoomSpriteFactory.Instance.CreateRightWall();

            
            door.Position = new Point(448, 265);

            Hitbox = door.Box;
        }


    }
}
