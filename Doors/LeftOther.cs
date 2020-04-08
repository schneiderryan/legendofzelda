using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

    class LeftOther : Door
    {
        public LeftOther()
        {
            door = RoomSpriteFactory.Instance.CreateLeftOther();
            door.Position = new Point(0, 145);
            Hitbox = door.Box;
        }

    }
}
