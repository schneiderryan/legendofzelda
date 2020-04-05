using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class RightOpen : Door
    {
       
        public RightOpen()
        {
            door = RoomSpriteFactory.Instance.CreateRightOpen();
            door.Scale = 2.0f;
            door.Position = new Point(448, 145);
            Hitbox = door.Box;
        }


        
    }
}
