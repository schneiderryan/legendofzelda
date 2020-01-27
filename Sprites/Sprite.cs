using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class Sprite : ISprite
    {
        private Texture2D texture;
        private float scale;
        private Point size;

        protected Rectangle sourceRect;

        public Point Position { get; set; }

        public float Scale {
            get { return scale; }
            set
            {
                scale = value;
                size = new Point((int)(value * sourceRect.Width),
                    (int)(value * sourceRect.Height));
            }
        }

        public Sprite(Texture2D texture, Rectangle sourecRect)
        {
            this.texture = texture;
            this.sourceRect = sourecRect;
        }

        public virtual void Draw(SpriteBatch sb)
        {
            Rectangle outRect = new Rectangle(Position, size);
            sb.Draw(texture, outRect, sourceRect, Color.White);
        }

        public virtual void Update() { /* no code needed */ }
    }
}
