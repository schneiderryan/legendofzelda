using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class MovableBlock : InvisibleBlock, IMoveableBlock
    {
        private ISprite sprite;
        private enum BlockState { Ready, Moved }
        private BlockState state = BlockState.Ready;
        private int vy = 0;
        private int moveCounter = 0;

        public MovableBlock()
        {
            sprite = RoomElementsSpriteFactory.GetBlockSprite();
        }

        public void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }

        public void MoveOnceUp()
        {
            if (state == BlockState.Ready)
            {
                vy = -1;
                moveCounter += 2;
            }
        }

        public void MoveOnceDown()
        {
            if (state == BlockState.Ready)
            {
                vy = 1;
                moveCounter += 2;
            }
        }

        public void Update()
        {
            if (moveCounter > 20 || Y % LevelParser.TILE_SIZE != 0)
            {
                Y += vy;
                state = BlockState.Moved;
            }
            if (moveCounter > 0)
            {
                moveCounter -= 1;
            }
            sprite.Position = new Point(X, Y);
        }

    }
}
