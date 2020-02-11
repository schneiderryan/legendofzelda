using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class Sprite : ISprite
    {
        private Texture2D texture;
        private float scale;
        private Point size;

        protected Rectangle sourceRect;

        public SpriteEffects Effects { get; set; }

        public Point Position { get; set; }

        public float Scale
        {
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
            Scale = 1.0f;
            Position = new Point();
        }

        public virtual void Draw(SpriteBatch sb, Color color)
        {
            Rectangle outRect = new Rectangle(Position, size);
            sb.Draw(texture, outRect, sourceRect, color);
        }

        public virtual void Update() { /* no code needed */ }
    }
}