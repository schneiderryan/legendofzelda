
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
        void PickupItem(int time);
        void Update();
        void Projectile();
    }
}
