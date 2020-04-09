using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class RightOpen : Door
    {
       
        public RightOpen()
        {
            door = RoomSpriteFactory.Instance.CreateRightOpen();

            door.Position = new Point(448, 144);
            Hitbox = new Rectangle(511, 163, 1, 30);

        }


        
    }
}
