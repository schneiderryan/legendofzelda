using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IEnemy : ICollideable
    {
        int CurrentStep { get; set; }
        int changeDirection { get; set; }
        int X { get; set; }
        int Y { get; set; }
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
