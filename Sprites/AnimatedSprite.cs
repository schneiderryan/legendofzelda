using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class AnimatedSprite : Sprite
    {
        protected readonly int nFrames;
        private int frameCounter = 0;
        private int delayCounter = 0;
<<<<<<< HEAD
        private Rectangle firstRect;
        private bool isRow;

        public int AnimationDelay { get; set; }

=======
        private bool isRow;

>>>>>>> 13c1858d758aae16be47ef65e6e8d6c186945d1f
        public AnimatedSprite(Texture2D texture, Rectangle firstFrame,
                int nFrames, bool isRow = true)
            : base(texture, firstFrame)
        {
            this.firstRect = firstFrame;
            this.nFrames = nFrames;
            this.isRow = isRow;
<<<<<<< HEAD
            AnimationDelay = 5;
=======
>>>>>>> 13c1858d758aae16be47ef65e6e8d6c186945d1f
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