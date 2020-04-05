using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class BottomOther : Door
    {
       
        public BottomOther()
        {
            door = RoomSpriteFactory.Instance.CreateBottomOther();
            door.Scale = 2.0f;
            door.Position = new Point(224, 288);
            Hitbox = door.Box;
        }


       
    }
}
