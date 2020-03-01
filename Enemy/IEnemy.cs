using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace LegendOfZelda
{
    interface IEnemy : ICollideable
    {
        int CurrentStep { get; set; }
        int listIndex { get; set; }
        bool isBeingAttacked { get; set; }
        int changeDirection { get; set; }
        int X { get; set; }
        int Y { get; set; }
        int xVel { get; set; }
        int yVel { get; set; }
        IEnemyState state { get; set; }
        ISprite sprite { get; set; }
        double currentHearts { get; set; }

        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();
        void TakeDamage();
        void BeStill();
        void Update();

        void Draw(SpriteBatch sb, Color color);
        void UseProjectile(IProjectile projectile);
        void Use(IEnemy enemy);
    }
}
