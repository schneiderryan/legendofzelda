using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class DamagedLink : IPlayer
    {
        LegendOfZelda game;
        IPlayer decoratedLink;
        int timer = 200;

        public DamagedLink (IPlayer decoratedLink, LegendOfZelda game)
        {
            this.decoratedLink = decoratedLink;
            this.game = game;
        }

        public void Attack()
        {
            decoratedLink.Attack();
        }

        public void BeStill()
        {
            decoratedLink.BeStill();
        }

        public void Draw(SpriteBatch sb, Color color)
        {
            decoratedLink.Draw(sb, Color.Red);
            // need to add color mask to drawing based on timer
        }

        public void MoveDown()
        {
            decoratedLink.MoveDown();
        }

        public void MoveLeft()
        {
            decoratedLink.MoveLeft();
        }

        public void MoveRight()
        {
            decoratedLink.MoveRight();
        }

        public void MoveUp()
        {
            decoratedLink.MoveUp();
        }

        public void TakeDamage()
        {
            // does not take damage
        }

        public void Update()
        {
            timer--;
            if(timer == 0)
            {
                RemoveDecorator();
            }
            decoratedLink.Update();
        }

        public void UseItem1()
        {
            decoratedLink.UseItem1();
        }

        public void UseItem2()
        {
            decoratedLink.UseItem2();
        }

        public void UseItem3()
        {
            decoratedLink.UseItem3();
        }
        public void RemoveDecorator()
        {
            game.link = decoratedLink;
        }
    }
}
