
namespace LegendOfZelda
{
    interface ILinkState : IUpdateable
    {
        void MoveUp();
        void MoveDown();
        void MoveRight();
        void MoveLeft();
        void Attack();
        void BeStill();
        void Knockback(int amountX, int amountY);
        void FireProjectile();
        void PickupItem(IItem item, int time, bool twoHands = true);
    }
}
