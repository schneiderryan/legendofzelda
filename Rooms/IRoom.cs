using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    interface IRoom : ICollideable
    {
        void Update();
        void Draw(SpriteBatch sb, Color color);
        void DrawDoor(SpriteBatch sb, Color color);
    }
}
