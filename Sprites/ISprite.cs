using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public interface ISprite
    {
        Point Position { get; set; }
        float Scale { get; set; }
        void Draw(SpriteBatch sb);
        void Update();
    }
}
