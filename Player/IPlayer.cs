using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    interface IPlayer
    {
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();
        void Attack();
        void BeStill();
        void Update();
        void UseItem1();
        void UseItem2();
        void UseItem3();
        void Draw(SpriteBatch sb);
    }
}
