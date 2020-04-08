using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class BottomKey : Door
    {
        
        public BottomKey()
        {
            door = RoomSpriteFactory.Instance.CreateBottomKey();
            door.Position = new Point(224, 288);
            Hitbox = door.Box;
        }


    }
}
