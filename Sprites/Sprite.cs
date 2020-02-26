using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class Sprite : ISprite
    {
        private readonly Texture2D texture;
        private float scale;
        protected Rectangle sourceRect;
        private Rectangle box;

        public SpriteEffects Effects { get; set; }
        public Point Position
        {
            get { return box.Location; }
            set { box.Location = value; }
        }

        public Rectangle Box
        {
            get { return box; }
        }

        public float Scale
        {
            get { return scale; }
            set
            {
                scale = value;
                box.Width = (int)(scale * sourceRect.Width);
                box.Height = (int)(scale * sourceRect.Height);
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