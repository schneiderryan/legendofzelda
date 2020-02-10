using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public interface IProjectile
    {
        void Update();
        void Draw(SpriteBatch sb);
    }
}