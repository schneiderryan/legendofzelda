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
        ILinkState state { get; set; }
        string direction { get; set; }
        string color { get; set; }
        int numRupees { get; set; }
        double maxHearts { get; set; }
        double currentHearts { get; set; }
        int numberBombs { get; set; }
        Rectangle SpriteBox { get; }
        Team Team { get; set; }
        void Attack();
        void BeStill();
        void TakeDamage();
        void UseItem(IItem item);
        void UseProjectile(IProjectile projectile);
        void Draw(SpriteBatch sb, Color color);
        void RegisterAttackKeys(List<Keys> attackKeys);
        bool IsAttacking();
    }
}
