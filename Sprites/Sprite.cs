using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class Sprite : ISprite
    {
        private readonly Texture2D texture;

        protected Rectangle sourceRect;

        public SpriteEffects Effects { get; set; }

        public Point Position { get; set; }

        public float Scale { get; set; }

        public Sprite(Texture2D texture, Rectangle sourecRect)
        {
            this.texture = texture;
            this.sourceRect = sourecRect;
            Scale = 2.0f;
            Position = new Point();
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