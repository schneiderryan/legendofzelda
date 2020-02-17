using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class Sprite : ISprite
    {
        private readonly Texture2D texture;
        private float scale;
        protected Rectangle sourceRect;

        public SpriteEffects Effects { get; set; }
        public Point Position { get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public float Scale
        {
            get { return scale; }
            set
            {
                scale = value;
                Width = (int)(scale * sourceRect.Width);
                Height = (int)(scale * sourceRect.Height);
            }
        }

        public Sprite(Texture2D texture, Rectangle sourecRect)
        {
            this.texture = texture;
            this.sourceRect = sourecRect;
            Scale = 2.0f;
            Effects = SpriteEffects.None;
        }

        public virtual void Draw(SpriteBatch sb, Color color)
        {
            Vector2 pos = new Vector2(Position.X, Position.Y);
            sb.Draw(texture, pos, sourceRect, color,
                0, new Vector2(), Scale, Effects, 0);
        }

        public virtual void Draw(SpriteBatch sb)
        {
            this.Draw(sb, Color.White);
        }

        public virtual void Update() { /* no code needed */ }
    }
}