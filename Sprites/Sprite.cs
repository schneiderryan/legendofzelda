using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class Sprite : ISprite
    {
        private Texture2D texture;

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

        public virtual void Draw(SpriteBatch sb)
        {
            Vector2 pos = new Vector2(Position.X, Position.Y);
            sb.Draw(texture, pos, sourceRect, Color.White,
                0, new Vector2(), Scale, Effects, 0);
        }

        public virtual void Update() { /* no code needed */ }
    }
}