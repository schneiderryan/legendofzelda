using System.Collections.Generic;
using System.Linq;


namespace LegendOfZelda
{
    class MovedBlockState : ImmoveableBlockState
    {
        public MovedBlockState(IDictionary<string, IDoor> doors)
        {
            foreach (KeyValuePair<string, IDoor> door in doors.ToList())
            {
                if (door.Key == "left" && door.Value is LeftOther)
                {
                    doors.Remove("left");
                    doors.Add("left", new LeftOpen());
                }
                if (door.Key == "right" && door.Value is RightOther)
                {
                    doors.Remove("right");
                    doors.Add("right", new RightOpen());
                }
            }
        }
    }
}
