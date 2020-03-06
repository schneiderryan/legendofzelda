
namespace LegendOfZelda
{
    public interface ILinkState
    {
        void MoveUp();
        void MoveDown();
        void MoveRight();
        void MoveLeft();
        void Attack();
        void BeStill();
        void Update();
        void Projectile();
    }
}
