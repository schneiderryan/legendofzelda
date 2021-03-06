﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;


namespace LegendOfZelda
{
    abstract class Link : IPlayer
    {
        private LegendOfZelda game;
        private int x;
        private int y;
        private int itemTimer;
        private int heartSoundTimer = 0;
        private Rectangle footbox;
        private Rectangle hitbox;
        private Rectangle attackBoxLeft;
        private Rectangle attackBoxRight;
        private Rectangle attackBoxUp;
        private Rectangle attackBoxDown;
        private Vector2 origin;
        private Color deadColor;

        public int ID { get; set; }
        public int InRoom { get; set; }
        public double Resistance { get; set; }
        public IItem HeldItem { get; set; }
        public IItem CurrentItem { get; set; }
        public ISprite Sprite { get; set; }
        public ILinkState State { get; set; }
        public bool HeartsCanCahnge { get; set; }
        public int attackSoundTimer = 0;
        public Rectangle Footbox => footbox;
        public Rectangle Hitbox => hitbox;
        public Rectangle LeftAttackBox => attackBoxLeft;
        public Rectangle RightAttackBox => attackBoxRight;
        public Rectangle DownAttackBox => attackBoxDown;
        public Rectangle UpAttackBox => attackBoxUp;
        public Color DeadColor 
        {
            get { return deadColor; }
            set { deadColor = value; }
        }

        public int X
        {
            get { return x; }
            set
            {
                attackBoxLeft.X += value - hitbox.X;
                attackBoxRight.X += value - hitbox.X;
                attackBoxDown.X += value - hitbox.X;
                attackBoxUp.X += value - hitbox.X;
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
                attackBoxLeft.Y += value - hitbox.Y;
                attackBoxRight.Y += value - hitbox.Y;
                attackBoxDown.Y += value - hitbox.Y;
                attackBoxUp.Y += value - hitbox.Y;
                footbox.Y = value + hitbox.Height - footbox.Height;
                hitbox.Y = value;
                y = value;
            }
        }

        public String Direction { get; set; }

        public String Color { get; set; }

        public double MaxHearts { get; set; }
        public double CurrentHearts { get; set; }
        public double DamageResistance { get; set; }

        public IInventory Inventory { get; protected set; }

        public Team Team { get; set; } = Team.Link;

        public Point Center => Sprite.Box.Center;

        public bool HeartsCanChange { get; set; }

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
            Sounds.GetAttackSound().Play();
            if (MaxHearts - CurrentHearts < 0.01) // close enough to 0 for a double
            {
                UseProjectile(new SwordProjectile(this.Direction, this.X, this.Y));
            }
            State.Attack();
        }

        public virtual void BeStill()
        {
            State.BeStill();
        }

        public void PickupItem(IItem item, int time, bool twoHands = true)
        {
            State.PickupItem(item, time, twoHands);
        }

        public virtual void TakeDamage(double amount)
        {
            Sounds.GetLinkHurtSound().Play();
            double actual = amount * (1.0 - Resistance);
            
            CurrentHearts -= actual;

            if (CurrentHearts < 0.01) // close enough to 0 for a double
            {
                Sounds.GetLinkDieSound().Play();
                this.State = new GreenLinkDeadState(this);
                game.LoseGame();
            }
            else
            {
                game.rooms[game.roomIndex].Players[ID] = new DamagedLink(this);
            }
        }

        public virtual void Update()
        {
            if(CurrentHearts < 1 && CurrentHearts > 0)
            {
                if(heartSoundTimer % 20 == 0)
                {
                    Sounds.GetLowHealthSound().Play();
                    
                }
                heartSoundTimer++;
            }
            State.Update();
            Sprite.Update();
            if (itemTimer > 0)
            {
                itemTimer--;
            }
        }

        public virtual void Draw(SpriteBatch sb, Color color)
        {
            Color tint = color;
            if (State is AttackingUpLinkState)
            {
                this.origin = new Vector2(0, 15);
            }
            else if (State is AttackingLeftLinkState)
            {
                this.origin = new Vector2(10, 0);
            }
            else if (State is LinkPickupState)
            {
                HeldItem.Draw(sb, Microsoft.Xna.Framework.Color.White);
                this.origin = new Vector2(0, 0);
            }
            else
            {
                this.origin = new Vector2(0, 0);
            }
            if (State is LinkDeadState)
            {
                tint = this.DeadColor;
            }
            Sprite.Draw(sb, tint, origin);
        }

        public virtual void UseProjectile(IProjectile projectile)
        {
            if (itemTimer == 0)
            {
                itemTimer = 45;
                Util.CenterRelativeToEdge(Sprite.Box, Direction, projectile);
                game.ProjectileManager.Add(projectile);
                State.FireProjectile();
                if(projectile is GreenArrowProjectile)
                {
                    this.Inventory.Rupees -= 1;
                }
            }
        }

        public virtual bool IsAttacking()
        {
            return State is AttackingGreenLinkState || State is AttackingRedLinkState
                || State is AttackingBlueLinkState;
        }

        protected void Initialize(LegendOfZelda game, int id)
        {
            this.ID = id;
            this.game = game;
            this.Direction = "up";
            this.Sprite.Scale = 2.0f;
            this.footbox = new Rectangle(0, 0, Sprite.Box.Width, Sprite.Box.Height / 2);
            this.hitbox = Sprite.Box;
            this.X = 250;
            this.Y = 295;
            this.attackBoxLeft = new Rectangle(x - 25, y + Sprite.Box.Height/4, 25, Sprite.Box.Height/2);
            this.attackBoxRight = new Rectangle(x + Sprite.Box.Width, y + Sprite.Box.Height / 4, 25, Sprite.Box.Height / 2);
            this.attackBoxUp = new Rectangle(x + Sprite.Box.Width/4, y - 25, Sprite.Box.Width/2, 25);
            this.attackBoxDown = new Rectangle(x + Sprite.Box.Width / 4, y + Sprite.Box.Height, Sprite.Box.Width / 2, 25);
            this.itemTimer = 0;
            if (game.currentMode.Equals("sudden death"))
            {
                this.MaxHearts = 0.5;
                this.CurrentHearts = 0.5;
                HeartsCanChange = false;
            } else
            {
                this.MaxHearts = 3.0;
                this.CurrentHearts = 3.0;
                HeartsCanChange = true;
            }
            this.Resistance = 0;
            this.origin = new Vector2(0, 0);
            this.Inventory = new Inventory();
            this.HeldItem = new Bomb();
            this.CurrentItem = new Boomerang();
            this.DeadColor = Microsoft.Xna.Framework.Color.White;
        }

        public void Knockback(int amountX, int amountY)
        {
            State.Knockback(amountX, amountY);
        }
    }
}
