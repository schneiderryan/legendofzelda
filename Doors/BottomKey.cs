using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class BottomKey : Door
    {
        
        public BottomKey()
        {
            door = RoomSpriteFactory.Instance.CreateBottomKey();
            door.Scale = 2.0f;
            door.Position = new Point(224, 288);
            Hitbox = door.Box;
        }


    }
}
