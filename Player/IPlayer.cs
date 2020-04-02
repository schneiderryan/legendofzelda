using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;


namespace LegendOfZelda
{
    interface IPlayer : ICharacter
    {
        ILinkState State { get; set; }
        string Direction { get; set; }
        string Color { get; set; }
        double MaxHearts { get; set; }
        double CurrentHearts { get; set; }
        double Resistance { get; set; }
        IInventory Inventory { get; }
        IItem HeldItem { get; set; }

        Rectangle Footbox { get; }
        Rectangle UpAttackBox { get; }
        Rectangle DownAttackBox { get; }
        Rectangle RightAttackBox { get; }
        Rectangle LeftAttackBox { get; }

        void Attack();
        void UseProjectile(IProjectile projectile);
        void Draw(SpriteBatch sb, Color color);
        void RegisterAttackKeys(List<Keys> attackKeys);
        bool IsAttacking();
        void PickupItem(IItem item, int time);
    }
}
