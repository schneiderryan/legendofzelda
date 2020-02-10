using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class MovingSprite : Sprite
    {
        private IPath path;

        public MovingSprite(Texture2D texture, in Rectangle sourceRect, IPath path)
            : base(texture, sourceRect)
        {
            this.path = path;
            this.Position = path.Position;
        }

        public override void Update()
        {
            path.Update();
            Position = path.Position;
            base.Update();
        }
    }
}
