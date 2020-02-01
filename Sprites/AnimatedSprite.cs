using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class AnimatedSprite : Sprite
    {
        private Rectangle firstRect;
        private int frameCounter = 0;
        private readonly int nFrames;
        private readonly int delay = 5;
        private int delayCounter = 0;

        public AnimatedSprite(Texture2D texture, Rectangle firstFrame, int nFrames)
            : base(texture, firstFrame)
        {
            this.firstRect = firstFrame;
            this.nFrames = nFrames;
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
                sourceRect.X = firstRect.X + frameCounter * 2 * firstRect.Width;
            }
        }
    }
}
