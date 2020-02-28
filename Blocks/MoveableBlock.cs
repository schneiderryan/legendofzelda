using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class MoveableBlock : InvisibleBlock, IMoveableBlock
    {
        private ISprite sprite;
        private enum BlockState { Ready, Moved }
        private BlockState state = BlockState.Ready;
        protected int vy = 0;
        protected int vx = 0;
        private int moveCounter = 0;

        public MoveableBlock()
        {
            sprite = RoomSpriteFactory.Instance.CreateBlock();
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

        public void MoveOnceLeft()
        {
            if (state == BlockState.Ready)
            {
                vx = -1;
                moveCounter += 2;
            }
        }

        public void MoveOnceRight()
        {
            if (state == BlockState.Ready)
            {
                vx = 1;
                moveCounter += 2;
            }
        }

        public void Update()
        {
            // check if the block has been pushed on for a bit,
            // or if the block is currently moving
            if (moveCounter > 20 || X % LevelParser.TILE_SIZE != 0
                    || Y % LevelParser.TILE_SIZE != 0)
            {
                Y += vy;
                X += vx;
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
