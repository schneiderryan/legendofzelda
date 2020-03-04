using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public interface ISprite
    {
        SpriteEffects Effects { get; set; }
        Point Position { get; set; }
        Rectangle Box { get; }
        int X { get; set; }
        int Y { get; set; }
        float Scale { get; set; }
        void Update();
        void Draw(SpriteBatch sb, Color color, Vector2 origin);
        void Draw(SpriteBatch sb);
        void Draw(SpriteBatch sb, Color color);

    }
}
