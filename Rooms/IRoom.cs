using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    interface IRoom : ICollideableRoom
    {
        //fields for types of objects that can spawn
        
        void Update();
        void Draw(SpriteBatch sb, Color color);
        void EnterRoomBelow();
        void EnterRoomAbove();
        void EnterRoomLeft();
        void EnterRoomRight();
        void DrawDoor(SpriteBatch spriteBatch, Color white);
    }
}
