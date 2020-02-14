using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public interface IPlayer
    {
        string direction { get; set; }
        string color { get; set; }
        int xPos { get; set; }
        int yPos { get; set; }
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();
        void Attack();
        void BeStill();
        void TakeDamage();
        void Update();
        void UseItem(IItem item);
        void UseProjectile(IProjectile item);
        void Draw(SpriteBatch sb, Color color);
        void RegisterAttackKeys(List<Keys> attackKeys);
        bool IsAttacking();
    }
}
