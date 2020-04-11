using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class RightOther : Door
    {
       
        public RightOther()
        {
            door = RoomSpriteFactory.Instance.CreateRightOther();
            door.Position = new Point(448, 265);
            Hitbox = door.Box;
        }


        
    }
}
