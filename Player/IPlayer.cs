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
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();
        void Attack();
        void BeStill();
        void TakeDamage();
        void Update();
        void UseItem1();
        void UseItem2();
        void UseItem3();
        void Draw(SpriteBatch sb, Color color);
    }
}
