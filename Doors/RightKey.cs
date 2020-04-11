using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class RightKey : Door
    {
       
        public RightKey()
        {
            door = RoomSpriteFactory.Instance.CreateRightKey();

            door.Position = new Point(448, 265);

            Hitbox = door.Box;
        }


        
    }
}
