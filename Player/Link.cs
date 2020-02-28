using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{
    abstract class Link : IPlayer
    {
        public LegendOfZelda game;

        private String d;
        private String c;
        private int x;
        private int y;
        private int itemTimer;
        private int numberOfRupees;
        private double numMaxHearts;
        private double numCurrHearts;
        private int numberOfBombs;
        private List<Keys> attackKeys;
        private Rectangle hitbox;

        public ISprite sprite { get; set; }
        public ILinkState state { get; set; }

        public Rectangle Hitbox
        {
            get { return hitbox; }
        }

        public int X
        {
            get { return x; }
            set
            { 
                hitbox.X = value;
                x = value;
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                hitbox.Y = value + sprite.Box.Height - hitbox.Height;
                y = value;
            }
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

        public int numberBombs
        {
            get { return numberOfBombs; }
            set { numberOfBombs = value; }
        }

        public virtual void MoveLeft()
        {
            state.MoveLeft();
        }

        public virtual void MoveRight()
        {
            state.MoveRight();
        }

        public virtual void MoveUp()
        {
            state.MoveUp();
        }

        public virtual void MoveDown()
        {
            state.MoveDown();
        }

        public virtual void Attack()
        {
            state.Attack();
        }

        public virtual void BeStill()
        {
            state.BeStill();
        }

        public virtual void TakeDamage()
        {
            this.game.link = new DamagedLink(this);
        }

        public virtual void Update()
        {
            state.Update();
            sprite.Update();
            if (itemTimer > 0)
            {
                itemTimer--;
            }
        }

        public virtual void Draw(SpriteBatch sb, Color color)
        {
            sprite.Draw(sb, color);
        }

        public virtual void UseProjectile(IProjectile projectile)
        {
            if (itemTimer == 0)
            {
                itemTimer = 75;
                game.currentRoom.projectiles.Add(projectile);
            }
        }

        public virtual void UseItem(IItem item)
        {
            item.Use(this);
        }

        public virtual void RegisterAttackKeys(List<Keys> attackKeys)
        {
            this.attackKeys = attackKeys;
        }

        public virtual bool IsAttacking()
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

        protected void Initialize(LegendOfZelda game)
        {
            this.game = game;
            this.d = "up";
            this.sprite.Scale = 2.0f;
            this.hitbox = new Rectangle(0, 0, sprite.Box.Width, 10);
            this.X = 400;
            this.Y = 200;
            this.itemTimer = 0;
            this.numRupees = 0;
            this.maxHearts = 3.0;
            this.currentHearts = 3.0;
        }
    }
}
