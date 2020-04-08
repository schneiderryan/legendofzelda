using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class BottomOther : Door
    {
       
        public BottomOther()
        {
            door = RoomSpriteFactory.Instance.CreateBottomOther();

            door.Position = new Point(225, 288);

            Hitbox = door.Box;
        }


       
    }
}
