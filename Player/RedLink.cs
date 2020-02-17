using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class RedLink : IPlayer
    {
        public LegendOfZelda game;
        public ISprite sprite;
        public ILinkState state;
        private int itemTimer;
        private int x;
        private int y;

        private String d;
        private String c;
        private int numberOfRupees;
        private double numMaxHearts;
        private double numCurrHearts;
        private List<Keys> attackKeys;


        public int xPos
        {
            get { return x; }
            set { x = value; }
        }

        public int yPos
        {
            get { return y; }
            set { y = value; }
        }

        public String direction
        {
            get { return d; }
            set { d = value; }
        }

        public String color
        {
            get { return c; }
            set { c = value; }
        }

        public int numRupees
        {
            get { return numberOfRupees; }
            set { numberOfRupees = value; }
        }

        public double maxHearts
        {
            get { return numMaxHearts; }
            set { numMaxHearts = value; }
        }
        public double currentHearts
        {
            get { return numCurrHearts; }
            set { numCurrHearts = value; }
        }

        public RedLink(LegendOfZelda game)
        {
            this.game = game;
            this.sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
            this.d = "up";
            this.c = "red";
            this.sprite.Scale = 2.0f;
            this.xPos = 400;
            this.yPos = 200;
            this.sprite.Position = new Point(xPos, yPos);
            this.state = new StillUpRedLinkState(this);
            this.itemTimer = 0;
            this.numRupees = 0;
            this.maxHearts = 3.0;
            this.currentHearts = 3.0;
        }

        public void MoveLeft()
        {
            state.MoveLeft();
        }

        public void MoveRight()
        {
            state.MoveRight();
        }
        
        public void MoveUp()
        {
            state.MoveUp();
        }

        public void MoveDown()
        {
            state.MoveDown();
        }

        public void Attack()
        {
            state.Attack();
        }

        public void BeStill()
        {
            state.BeStill();
        }

        public void Update()
        {
            state.Update();
            sprite.Update();
            if(itemTimer > 0)
            {
                itemTimer--;
            }
        }

        public void Draw(SpriteBatch sb, Color color)
        {
            sprite.Draw(sb, color);
        }

        public void UseProjectile(IProjectile projectile)
        {
            if (itemTimer == 0)
            {
                itemTimer = 75;
                game.projectiles.Add(projectile);
            }
        }

        public void UseItem(IItem item)
        {
            item.Use(this);
        }

        public void TakeDamage()
        {
            this.game.link = new DamagedLink(this, this.game);
        }

        public void RegisterAttackKeys(List<Keys> attackKeys)
        {
            this.attackKeys = attackKeys;
        }

        public bool IsAttacking()
        {
            foreach (Keys key in this.attackKeys)
            {
                if (Keyboard.GetState().IsKeyDown(key))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
