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

        public int X { get => box.X; set => box.X = value; }
        public int Y { get => box.Y; set => box.Y = value; }

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

        public virtual void Draw(SpriteBatch sb, Color color, Vector2 origin)
        {
            Vector2 pos = new Vector2(Position.X, Position.Y);
            sb.Draw(texture, pos, sourceRect, color,
                0, origin, Scale, Effects, 0);
        }

        public virtual void Draw(SpriteBatch sb)
        {
            Vector2 origin = new Vector2(0, 0);
            this.Draw(sb, Color.White, origin);
        }

        public virtual void Draw(SpriteBatch sb, Color color)
        {
            Vector2 origin = new Vector2(0, 0);
            this.Draw(sb, color, origin);
        }

        public virtual void Update() { /* no code needed */ }
    }
}