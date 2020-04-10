using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class RightOpen : Door
    {
       
        public RightOpen()
        {
            door = RoomSpriteFactory.Instance.CreateRightOpen();

            door.Position = new Point(448, 265);
            Hitbox = new Rectangle(511, 283, 1, 30);

        }


        
    }
}
