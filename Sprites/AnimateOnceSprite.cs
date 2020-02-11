using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class AnimateOnceSprite : AnimatedSprite
    {
        private int frameCounter = 0;

        public bool AnimationEnded { get; private set; }

        public AnimateOnceSprite(Texture2D texture, Rectangle firstFrame,
                int nFrames, bool isRow = true)
            : base(texture, firstFrame, nFrames, isRow)
        {
            AnimationEnded = false;
        }

        public override void Update()
        {
            if (!AnimationEnded)
            {
                base.Update();
                frameCounter++;
                AnimationEnded = frameCounter >= AnimationDelay * (nFrames - 1);
            }
        }
    }
}
