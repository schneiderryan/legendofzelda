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
        int timer = 1000;

        public DamagedLink (IPlayer decoratedLink, LegendOfZelda game)
        {
            this.decoratedLink = decoratedLink;
            this.game = game;
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void BeStill()
        {
            throw new NotImplementedException();
        }

        public void Draw(SpriteBatch sb)
        {
            throw new NotImplementedException();
        }

        public void MoveDown()
        {
            throw new NotImplementedException();
        }

        public void MoveLeft()
        {
            throw new NotImplementedException();
        }

        public void MoveRight()
        {
            throw new NotImplementedException();
        }

        public void MoveUp()
        {

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
            throw new NotImplementedException();
        }

        public void UseItem2()
        {
            throw new NotImplementedException();
        }

        public void UseItem3()
        {
            throw new NotImplementedException();
        }
        public void RemoveDecorator()
        {
            game.link = decoratedLink;
        }
    }
}
