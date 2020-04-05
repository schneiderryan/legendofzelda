using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class RightKey : Door
    {
       
        public RightKey()
        {
            door = RoomSpriteFactory.Instance.CreateRightKey();
            door.Scale = 2.0f;
            door.Position = new Point(448, 145);
            Hitbox = door.Box;
        }


        
    }
}
