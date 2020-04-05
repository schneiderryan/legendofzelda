using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class LeftKey : Door
    {
       
        public LeftKey()
        {
            door = RoomSpriteFactory.Instance.CreateLeftKey();
            door.Scale = 2.0f;
            door.Position = new Point(0, 145);
        }


    }
}
