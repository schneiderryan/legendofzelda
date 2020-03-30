using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class DamagedLink : IPlayer
    {
        IPlayer decoratedLink;
        LegendOfZelda game;
        int timer = 192; // to give about 3 seconds

        public Rectangle Footbox
        {
            get { return decoratedLink.Footbox; }
        }

        public Rectangle LeftAttackBox
        {
            get { return decoratedLink.LeftAttackBox; }
        }

        public Rectangle RightAttackBox
        {
            get { return decoratedLink.RightAttackBox; }
        }

        public Rectangle DownAttackBox
        {
            get { return decoratedLink.DownAttackBox; }
        }

        public Rectangle UpAttackBox
        {
            get { return decoratedLink.UpAttackBox; }
        }

        public ISprite Sprite
        {
            get { return decoratedLink.Sprite; }
            set { decoratedLink.Sprite = value; }
        }

        public ILinkState State
        {
            get { return decoratedLink.State; }
            set { decoratedLink.State = value; }
        }

        public int X
        {
            get { return decoratedLink.X; }
            set { decoratedLink.X = value; }
        }

        public int Y
        {
            get { return decoratedLink.Y; }
            set { decoratedLink.Y = value; }
        }

        public String Direction
        {
            get { return decoratedLink.Direction; }
            set { decoratedLink.Direction = value; }
        }

        public String Color
        {
            get { return decoratedLink.Color; }
            set { decoratedLink.Color = value; }
        }

        public int NumRupees
        {
            get { return decoratedLink.NumRupees; }
            set { decoratedLink.NumRupees = value; }
        }

        public double MaxHearts
        {
            get { return decoratedLink.MaxHearts; }
            set { decoratedLink.MaxHearts = value; }
        }
        
        public double CurrentHearts
        {
            get { return decoratedLink.CurrentHearts; }
            set { decoratedLink.CurrentHearts = value; }
        }

        public int NumberBombs
        {
            get { return decoratedLink.NumberBombs; }
            set { decoratedLink.NumberBombs = value; }
        }
        public int NumberKeys
        {
            get { return decoratedLink.NumberKeys; }
            set { decoratedLink.NumberKeys = value; }
        }

        public Team Team { get => decoratedLink.Team; set => decoratedLink.Team = value; }

        public Point Center => decoratedLink.Center;

        public Rectangle Hitbox => decoratedLink.Hitbox;

        public DamagedLink (LegendOfZelda game)
        {
            this.game = game;
            this.decoratedLink = game.link;
        }

        public void Attack()
        {
            decoratedLink.Attack();
        }

        public void BeStill()
        {
            decoratedLink.BeStill();
        }

        public void PickupItem(IItem item, int time)
        {
            decoratedLink.PickupItem(item, time);
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
                decoratedLink.Draw(sb, Microsoft.Xna.Framework.Color.White);
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
            if (timer == 0)
            {
                game.link = decoratedLink;
            }
            decoratedLink.Update();
        }

        public void UseItem(IItem item)
        {
            decoratedLink.UseItem(item);
        }

        public void UseProjectile(IProjectile projectile)
        {
            decoratedLink.UseProjectile(projectile);
        }

        public void RegisterAttackKeys(List<Keys> attackKeys)
        {
            decoratedLink.RegisterAttackKeys(attackKeys);
        }

        public bool IsAttacking()
        {
            return decoratedLink.IsAttacking();
        }

    }
}
