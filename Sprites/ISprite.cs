using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public interface ISprite
    {
        SpriteEffects Effects { get; set; }
        Point Position { get; set; }
        float Scale { get; set; }
        void Update();
        void Draw(SpriteBatch sb, Color color);
        void Draw(SpriteBatch sb);
    }
}
