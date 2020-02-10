using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public interface ISprite
    {
        SpriteEffects Effects { get; set; }
        Point Position { get; set; }
        float Scale { get; set; }
        void Draw(SpriteBatch sb);
        void Update();
    }
}
