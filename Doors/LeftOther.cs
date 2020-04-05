using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class LeftOther : Door
    {
        public LeftOther()
        {
            door = RoomSpriteFactory.Instance.CreateLeftOther();
            door.Scale = 2.0f;
            door.Position = new Point(0, 145);
            Hitbox = door.Box;
        }

    }
}
