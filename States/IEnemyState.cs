
namespace LegendOfZelda
{
    interface IEnemyState : IUpdateable
    {
        void MoveDown();
        void MoveUp();
        void MoveRight();
        void MoveLeft();
        void BeStill();
        void Knockback(int amountX, int amountY);
    }
}
