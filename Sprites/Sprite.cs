using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class Sprite : ISprite
    {
        private Texture2D texture;

        protected Rectangle sourceRect;
        private float scale;
        private Point size;

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

        public virtual void Draw(SpriteBatch sb)
        {
            Vector2 pos = new Vector2(Position.X, Position.Y);
            sb.Draw(texture, pos, sourceRect, Color.White,
                0, new Vector2(), Scale, Effects, 0);
        }

        public virtual void Update() { /* no code needed */ }
    }
}