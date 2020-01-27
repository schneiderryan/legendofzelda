using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class DancingSprite : AnimatedSprite
    {
        private IPath path;
        public DancingSprite(Texture2D texture, in Rectangle firstFrame, int nFrames, IPath path)
            : base(texture, firstFrame, nFrames)
        {
            this.path = path;
            Position = path.Position;
        }

        public override void Update()
        {
            path.Update();
            Position = path.Position;
            base.Update();
        }
    }
}
