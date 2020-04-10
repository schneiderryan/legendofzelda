using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendOfZelda
{
    class MoveableBlock : InvisibleBlock, IMoveableBlock
    {
        private ISprite sprite;
        private enum BlockState { Ready, Moved }
        private BlockState state = BlockState.Ready;
        protected int vy = 0;
        protected int vx = 0;
        protected int moveCounter = 0;
        protected IRoom room;

        public MoveableBlock(IRoom room)
        {
            this.room = room;
            sprite = RoomSpriteFactory.Instance.CreateBlock();
        }

        public override void Draw(SpriteBatch sb, Color color)
        {
            sprite.Draw(sb, color);
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

        public override void Update()
        {
            if (state == BlockState.Moved && X % RoomParser.TILE_SIZE == 0 && Y % RoomParser.TILE_SIZE == 0 )
            {
                foreach (KeyValuePair<String, IDoor> door in room.Doors.ToList())
                {
                    if (door.Key == "left" && door.Value is LeftOther)
                    {
                        room.Doors.Remove("left");
                        room.Doors.Add("left", new LeftOpen());
                    }
                }
            }
            // check if the block has been pushed on for a bit,
            // or if the block is currently moving
            if (moveCounter > 20 || X % RoomParser.TILE_SIZE != 0
                    || Y % RoomParser.TILE_SIZE != 0)
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
