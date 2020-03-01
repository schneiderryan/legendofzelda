using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IEnemy : ICollideable
    {
        ISprite Sprite { get; set; }
        IEnemyState State { get; set; }
        int VX { get; set; }
        int VY { get; set; }
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
