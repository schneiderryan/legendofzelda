﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface INPC : ICollideable
    {
        void Update();
        void Draw(SpriteBatch sb, Color color);
    }
}
