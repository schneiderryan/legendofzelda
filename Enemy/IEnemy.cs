using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public interface IEnemy
    {
        int currentStep { get; set; }
        int changeDirection { get; set; }
        int xPos { get; set; }
        int yPos { get; set; }
        int xVel { get; set; }
        int yVel { get; set; }
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();

        void BeStill();
        void Update();

        void Draw(SpriteBatch spriteBatch);
        void UseProjectile(IProjectile projectile);
        void Use(IEnemy enemy);
    }
}
