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
        int timer = 192; // to give about 3 seconds

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
            // rgba
            Color hurt1 = new Color(83, 68, 198);
            Color hurt2 = new Color(184, 101, 22);
            Color hurt3 = new Color(76, 80, 69);

            if (timer<=8 || timer>=33 && timer<=40 || timer>=65 && timer<=72 || timer>=97 && timer<=104 || timer>=129 && timer<=136 || timer>=161 && timer<=168)
            {
                decoratedLink.Draw(sb, hurt1);
            }
            else if (timer<=16 || timer>=41 && timer<=48 || timer>=73 && timer<= 80 || timer>=105 && timer<=112 || timer>=137 && timer<=144 || timer>=169 && timer<=176)
            {
                decoratedLink.Draw(sb, hurt2);
            }
            else if (timer<=24 || timer>=49 && timer<=56 || timer>=81 && timer<=88 || timer>=113 && timer<=120 || timer>=145 && timer<=152 || timer>=177 && timer<=184)
            {
                decoratedLink.Draw(sb, hurt3);
            }
            else
            {
                decoratedLink.Draw(sb, Color.White);
            }
            
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

        public void UseItem(ProjectileItem item)
        {
            decoratedLink.UseItem(item);
        }

        public void RemoveDecorator()
        {
            game.link = decoratedLink;
        }
    }
}
