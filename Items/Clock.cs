using Microsoft.Xna.Framework;
using System;

namespace LegendOfZelda
{
    class Clock : Item
    {
        public Clock()
        {
            sprite = ItemSpriteFactory.GetClock();
            Hitbox = sprite.Box;
        }
        public override void Use(IPlayer player)
        {
            //
        }
    }
}
