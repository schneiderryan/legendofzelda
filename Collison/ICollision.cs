using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    interface ICollision
    {
        String Direction { get; set; }
        void Handle();
    }
}
