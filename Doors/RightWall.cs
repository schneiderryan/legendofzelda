using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class RightWall : Door
    {
        
        public RightWall()
        {
            door = RoomSpriteFactory.Instance.CreateRightWall();
            door.Scale = 2.0f;
            door.Position = new Point(448, 145);
            Hitbox = door.Box;
        }


    }
}
