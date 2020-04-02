using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class DamagedLink : IPlayer
    {
        public IPlayer InnerLink { get; private set; }

        const int ANIMATION_TIME = 192; // to give about 3 seconds
        int timer = ANIMATION_TIME;
        LegendOfZelda game;

        public Rectangle Footbox => InnerLink.Footbox;
        public Rectangle LeftAttackBox => InnerLink.LeftAttackBox;
        public Rectangle RightAttackBox => InnerLink.RightAttackBox;
        public Rectangle DownAttackBox => InnerLink.DownAttackBox;
        public Rectangle UpAttackBox => InnerLink.UpAttackBox;

        public ISprite Sprite
        {
            get { return InnerLink.Sprite; }
            set { InnerLink.Sprite = value; }
        }

        public ILinkState State
        {
            get { return InnerLink.State; }
            set { InnerLink.State = value; }
        }

        public int X
        {
            get { return InnerLink.X; }
            set { InnerLink.X = value; }
        }

        public int Y
        {
            get { return InnerLink.Y; }
            set { InnerLink.Y = value; }
        }

        public String Direction
        {
            get { return InnerLink.Direction; }
            set { InnerLink.Direction = value; }
        }

        public String Color
        {
            get { return InnerLink.Color; }
            set { InnerLink.Color = value; }
        }

        public double MaxHearts
        {
            get { return InnerLink.MaxHearts; }
            set { InnerLink.MaxHearts = value; }
        }
        
        public double CurrentHearts
        {
            get { return InnerLink.CurrentHearts; }
            set { InnerLink.CurrentHearts = value; }
        }

        public IInventory Inventory => InnerLink.Inventory;

        public Team Team { get => InnerLink.Team; set => InnerLink.Team = value; }

        public Point Center => InnerLink.Center;

        public Rectangle Hitbox => InnerLink.Hitbox;

        public IItem HeldItem { get => InnerLink.HeldItem; set => InnerLink.HeldItem = value; }
        public double Resistance { get => InnerLink.Resistance; set => InnerLink.Resistance = value; }

        public DamagedLink (LegendOfZelda game)
        {
            this.game = game;
            this.InnerLink = game.link;
        }

        public void Attack()
        {
            InnerLink.Attack();
        }

        public void BeStill()
        {
            InnerLink.BeStill();
        }

        public void Draw(SpriteBatch sb, Color color)
        {
            Color hurt1 = new Color(83, 68, 198);
            Color hurt2 = new Color(184, 101, 22);
            Color hurt3 = new Color(76, 80, 69);

            if (timer<=8 || timer>=33 && timer<=40 || timer>=65 && timer<=72 || timer>=97 && timer<=104 || timer>=129 && timer<=136 || timer>=161 && timer<=168)
            {
                InnerLink.Draw(sb, hurt1);
            }
            else if (timer<=16 || timer>=41 && timer<=48 || timer>=73 && timer<= 80 || timer>=105 && timer<=112 || timer>=137 && timer<=144 || timer>=169 && timer<=176)
            {
                InnerLink.Draw(sb, hurt2);
            }
            else if (timer<=24 || timer>=49 && timer<=56 || timer>=81 && timer<=88 || timer>=113 && timer<=120 || timer>=145 && timer<=152 || timer>=177 && timer<=184)
            {
                InnerLink.Draw(sb, hurt3);
            }
            else
            {
                InnerLink.Draw(sb, color);
            }
        }

        public void MoveDown()
        {
            InnerLink.MoveDown();
        }

        public void MoveLeft()
        {
            InnerLink.MoveLeft();
        }

        public void MoveRight()
        {
            InnerLink.MoveRight();
        }

        public void MoveUp()
        {
            InnerLink.MoveUp();
        }

        public void TakeDamage(double amount)
        {
            // does not take damage
        }

        public void Update()
        {
            timer--;
            if (InnerLink.Inventory.HasClock)
            {
                foreach (IEnemy enemy in game.rooms[game.roomIndex].Enemies)
                {
                    enemy.BeStill();
                }
                if (timer <= 0)
                {
                    timer = ANIMATION_TIME;
                }
            }
            else if (timer <= 0)
            {
                game.link = InnerLink;
            }
            InnerLink.Update();
        }

        public void UseProjectile(IProjectile projectile)
        {
            InnerLink.UseProjectile(projectile);
        }

        public void RegisterAttackKeys(List<Keys> attackKeys)
        {
            InnerLink.RegisterAttackKeys(attackKeys);
        }

        public bool IsAttacking()
        {
            return InnerLink.IsAttacking();
        }

        public void PickupItem(IItem item, int time, bool twoHands = true)
        {
            InnerLink.PickupItem(item, time, twoHands);
        }
    }
}
