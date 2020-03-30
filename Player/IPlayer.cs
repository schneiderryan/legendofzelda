using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    interface IPlayer : ICharacter
    {
        ILinkState State { get; set; }
        string Direction { get; set; }
        string Color { get; set; }
        double MaxHearts { get; set; }
        double CurrentHearts { get; set; }
        IInventory Inventory { get; }

        Rectangle Footbox { get; }
        Rectangle UpAttackBox { get; }
        Rectangle DownAttackBox { get; }
        Rectangle RightAttackBox { get; }
        Rectangle LeftAttackBox { get; }

        void WearRedRing();
        void WearBlueRing();
        void Attack();
        void BeStill();
        void UseProjectile(IProjectile projectile);
        void Draw(SpriteBatch sb, Color color);
        void RegisterAttackKeys(List<Keys> attackKeys);
        bool IsAttacking();
    }
}
