using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    interface IRoom
    {
        void Update();
        void Draw(SpriteBatch sb, Color color);
        void EnterRoomBelow();
        void EnterRoomAbove();
        void EnterRoomLeft();
        void EnterRoomRight();
    }
}
