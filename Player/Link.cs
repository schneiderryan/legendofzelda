using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;


namespace LegendOfZelda
{
    abstract class Link : IPlayer
    {
        private LegendOfZelda game;
        private int x;
        private int y;
        private int itemTimer;
        private List<Keys> attackKeys;
        private Rectangle footbox;
        private Rectangle hitbox;
        private Rectangle attackBoxLeft;
        private Rectangle attackBoxRight;
        private Rectangle attackBoxUp;
        private Rectangle attackBoxDown;
        private Vector2 origin;
        private Color deadColor;
        public double Resistance { get; set; }
        public IItem HeldItem { get; set; }
        public ISprite Sprite { get; set; }
        public ILinkState State { get; set; }

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
                footbox.Y = value + Sprite.Box.Height - footbox.Height;
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

        public void PickupItem(IItem item, int time, bool twoHands = true)
        {
            State.PickupItem(item, time, twoHands);
        }

        public virtual void TakeDamage(double amount)
        {
            double actual = amount * (1.0 - Resistance);
            System.Diagnostics.Debug.WriteLine("link took: " + actual + " damage");
            CurrentHearts -= actual;
            if (CurrentHearts < 0.01) // close enough to 0 for a double
            {
                this.State = new GreenLinkDeadState(this);
                game.LoseGame();
            }
            else
            {
                this.game.link = new DamagedLink(game);
            }
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
                itemTimer = 75;
                Util.CenterRelativeToEdge(Sprite.Box, Direction, projectile);
                game.ProjectileManager.Add(projectile);
                State.FireProjectile();
            }
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
            this.MaxHearts = 3.0;
            this.CurrentHearts = 3.0;
            this.Resistance = 0;
            this.origin = new Vector2(0, 0);
            this.Inventory = new Inventory();
            this.DeadColor = Microsoft.Xna.Framework.Color.White;
        }

        public void Knockback(int amountX, int amountY)
        {
            State.Knockback(amountX, amountY);
        }
    }
}
