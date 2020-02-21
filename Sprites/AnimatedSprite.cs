using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class AnimatedSprite : Sprite
    {
        protected int nFrames;
        private int frameCounter = 0;
        private int delayCounter = 0;
        private Rectangle firstRect;
        private readonly bool isRow;

        public int AnimationDelay { get; set; }


        public AnimatedSprite(Texture2D texture, Rectangle firstFrame,
                int nFrames, bool isRow = true)
            : base(texture, firstFrame)
        {
            this.firstRect = firstFrame;
            this.nFrames = nFrames;
            this.isRow = isRow;
            AnimationDelay = 5;
        }

        public override void Update()
        {
            // delay updating the frame to make it animate slower
            delayCounter++;
            if (delayCounter >= AnimationDelay)
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