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
        private Rectangle footbox;
        private Rectangle hitbox;
        private Vector2 origin;

        public ISprite Sprite { get; set; }
        public ILinkState State { get; set; }

        public Rectangle Footbox => footbox;
        public Rectangle Hitbox => hitbox;

        public int X
        {
            get { return x; }
            set
            { 
                footbox.X = value;
                hitbox.X = value;
                x = value;
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                footbox.Y = value + Sprite.Box.Height - footbox.Height;
                hitbox.Y = value;
                y = value;
            }
        }

        public String Direction
        {
            get { return d; }
            set { d = value; }
        }

        public String Color
        {
            get { return c; }
            set { c = value; }
        }

        public int NumRupees
        {
            get { return numberOfRupees; }
            set { numberOfRupees = value; }
        }

        public double MaxHearts
        {
            get { return numMaxHearts; }
            set { numMaxHearts = value; }
        }
        public double CurrentHearts
        {
            get { return numCurrHearts; }
            set { numCurrHearts = value; }
        }

        public int NumberBombs
        {
            get { return numberOfBombs; }
            set { numberOfBombs = value; }
        }

        public Team Team { get; set; } = Team.Link;

        public Point Center => Sprite.Box.Center;

        public virtual void MoveLeft()
        {
            State.MoveLeft();
        }

        public virtual void MoveRight()
        {
            State.MoveRight();
        }

        public virtual void MoveUp()
        {
            State.MoveUp();
        }

        public virtual void MoveDown()
        {
            State.MoveDown();
        }

        public virtual void Attack()
        {
            State.Attack();
        }

        public virtual void BeStill()
        {
            State.BeStill();
        }

        public virtual void TakeDamage()
        {
            this.game.link = new DamagedLink(game);
        }

        public virtual void Update()
        {
            State.Update();
            Sprite.Update();
            if (itemTimer > 0)
            {
                itemTimer--;
            }
        }

        public virtual void Draw(SpriteBatch sb, Color color)
        {
            if (State is AttackingUpLinkState)
            {
                this.origin = new Vector2(0, 15);
                Sprite.Draw(sb, color, origin);
            }
            if (State is AttackingLeftLinkState)
            {
                this.origin = new Vector2(15, 0);
                Sprite.Draw(sb, color, origin);
            }
            else
            {
                this.origin = new Vector2(0, 0);
                Sprite.Draw(sb, color, origin);
            }
        }

        public virtual void UseProjectile(IProjectile projectile)
        {
            if (itemTimer == 0)
            {
                itemTimer = 75;
                Projectile.CenterProjectile(Sprite.Box, Direction, projectile);
                game.projectiles.Add(projectile);

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
            this.Sprite.Scale = 2.0f;
            this.footbox = new Rectangle(0, 0, Sprite.Box.Width, Sprite.Box.Height / 2);
            this.hitbox = Sprite.Box;
            this.X = 400;
            this.Y = 200;
            this.itemTimer = 0;
            this.NumRupees = 0;
            this.MaxHearts = 3.0;
            this.CurrentHearts = 3.0;
            this.origin = new Vector2(0, 0);
        }
    }
}
