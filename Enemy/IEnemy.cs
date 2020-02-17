using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public interface IEnemy
    {
        int currentStep { get; set; }
        int changeDirection { get; set; }

        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();

        void BeStill();
        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
