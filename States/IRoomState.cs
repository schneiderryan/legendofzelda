using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    interface IRoomState
    {
        void EnterRoomBelow();
        void EnterRoomAbove();
        void EnterRoomLeft();
        void EnterRoomRight();
        void Update();
    }
}
