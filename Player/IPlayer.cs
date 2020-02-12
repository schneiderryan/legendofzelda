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
        void UseItem(IProjectile item);
        void Draw(SpriteBatch sb, Color color);
    }
}
