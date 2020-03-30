﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class InvisibleBlock : CollideableObject, IBlock
    {
        public InvisibleBlock()
        {
            Hitbox = new Rectangle(0, 0, LevelParser.TILE_SIZE, LevelParser.TILE_SIZE);
        }

        public virtual void Update()
        {
            // nothing to update
        }

        public virtual void Draw(SpriteBatch sb, Color color)
        {
            // do nothing, it's invisible
        }
    }
}
