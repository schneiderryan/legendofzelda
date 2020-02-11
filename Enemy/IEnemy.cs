using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    interface IEnemy
    {
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();

        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
