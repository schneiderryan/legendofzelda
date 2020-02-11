using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public interface ISprite
    {
        Point Position { get; set; }
        float Scale { get; set; }
        void Draw(SpriteBatch sb, Color color);
        void Update();
    }
}
