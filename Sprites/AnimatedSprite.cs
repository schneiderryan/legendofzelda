﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class AnimatedSprite : Sprite
    {
        private Rectangle firstRect;
        private int frameCounter = 0;
        private readonly int nFrames;
        private readonly int delay = 5;
        private int delayCounter = 0;
        private bool isRow;

        public AnimatedSprite(Texture2D texture, Rectangle firstFrame,
                int nFrames, bool isRow = true)
            : base(texture, firstFrame)
        {
            this.firstRect = firstFrame;
            this.nFrames = nFrames;
            this.isRow = isRow;
        }

        public override void Update()
        {
            // delay updating the frame to make it animate slower
            delayCounter++;
            if (delayCounter >= delay)
            {
                delayCounter = 0;
                frameCounter++;
                frameCounter %= nFrames;

                // times 2 because of how the spritesheet is formated
                if (isRow)
                {
                    sourceRect.X = firstRect.X + frameCounter * 2 * firstRect.Width;
                }
                else
                {
                    sourceRect.Y = firstRect.Y + frameCounter * 2 * firstRect.Height;
                }
            }
        }
    }
}