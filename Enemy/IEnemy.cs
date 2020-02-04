using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public interface IEnemy
    {
        int currentStep { get; set; }
        int changeDirection { get; set; }

        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();

        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
