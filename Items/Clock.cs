using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class Clock : Item
    {
        public Clock()
        {
            sprite = ItemSpriteFactory.GetClock();
        }
        public override void Use(IPlayer player)
        {
            throw new NotImplementedException();
        }
    }
}
