using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    interface IRoom
    {
        void Update();
        void Draw(SpriteBatch sb);
        void DrawOverlay(SpriteBatch sb);
    }
}
