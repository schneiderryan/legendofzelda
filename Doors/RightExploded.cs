using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class RightExploded : Door
    {
        
        public RightExploded()
        {
            door = RoomSpriteFactory.Instance.CreateRightExploded();
            door.Scale = 2.0f;
            door.Position = new Point(448, 145);
            Hitbox = door.Box;
        }


        
    }
}
