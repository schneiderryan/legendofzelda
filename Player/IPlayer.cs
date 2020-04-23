using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    interface IPlayer : ICharacter
    {
        int ID { get; set; }
        ILinkState State { get; set; }
        string Direction { get; set; }
        string Color { get; set; }
        double MaxHearts { get; set; }
        double CurrentHearts { get; set; }
        double Resistance { get; set; }
        bool HeartsCanChange { get; set; }
        IInventory Inventory { get; }
        IItem HeldItem { get; set; }
        IItem CurrentItem { get; set; }
        Rectangle Footbox { get; }
        Rectangle UpAttackBox { get; }
        Rectangle DownAttackBox { get; }
        Rectangle RightAttackBox { get; }
        Rectangle LeftAttackBox { get; }
        Color DeadColor { get; set; }

        void Attack();
        void UseProjectile(IProjectile projectile);
        void Draw(SpriteBatch sb, Color color);
        bool IsAttacking();
        void PickupItem(IItem item, int time, bool twoHands = true);
    }
}
