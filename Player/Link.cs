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

        private int x;
        private int y;
        private int itemTimer;
        private List<IItem> pickedUpItem;
        private List<Keys> attackKeys;
        private Rectangle footbox;
        private Rectangle hitbox;
        private Rectangle attackBoxLeft;
        private Rectangle attackBoxRight;
        private Rectangle attackBoxUp;
        private Rectangle attackBoxDown;
        private Vector2 origin;

        public ISprite Sprite { get; set; }
        public ILinkState State { get; set; }

        public Rectangle Footbox => footbox;
        public Rectangle Hitbox => hitbox;
        public Rectangle LeftAttackBox => attackBoxLeft;
        public Rectangle RightAttackBox => attackBoxRight;
        public Rectangle DownAttackBox => attackBoxDown;
        public Rectangle UpAttackBox => attackBoxUp;

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

        public int NumRupees { get; set; }

        public double MaxHearts { get; set; }
        public double CurrentHearts { get; set; }

        public int NumberBombs { get; set; }

        public int NumberKeys { get; set; }

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

        public virtual void PickupItem(IItem item, int time)
        {
            State.PickupItem(time);
            item.X = this.game.link.X;
            item.Y = this.game.link.Y + item.Hitbox.Height;
            pickedUpItem.Add(item);
        }

        public virtual void TakeDamage()
        {
            this.game.link = new DamagedLink(game);
            CurrentHearts -= 0.5;
            if(CurrentHearts == 0)
            {
                game.LoseGame();
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

            if (pickedUpItem.Count != 0)
            {
                pickedUpItem[0].Update();
            }
        }

        public virtual void Draw(SpriteBatch sb, Color color)
        {
            if (State is AttackingUpLinkState)
            {
                this.origin = new Vector2(0, 15);
                Sprite.Draw(sb, color, origin);
            }
            else if (State is AttackingLeftLinkState)
            {
                this.origin = new Vector2(10, 0);
                Sprite.Draw(sb, color, origin);
            }
            else
            {
                this.origin = new Vector2(0, 0);
                Sprite.Draw(sb, color, origin);
            }

            if(pickedUpItem.Count != 0)
            {
                pickedUpItem[0].Draw(sb, Microsoft.Xna.Framework.Color.White);
            }
        }

        public virtual void UseProjectile(IProjectile projectile)
        {
            if (itemTimer == 0)
            {
                itemTimer = 75;
                Projectile.CenterProjectile(Sprite.Box, Direction, projectile);
                game.projectiles.Add(projectile);
                State.Projectile();
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
            this.Direction = "up";
            this.Sprite.Scale = 2.0f;
            this.footbox = new Rectangle(0, 0, Sprite.Box.Width, Sprite.Box.Height / 2);
            this.hitbox = Sprite.Box;
            this.X = 400;
            this.Y = 200;
            this.attackBoxLeft = new Rectangle(x - 25, y + Sprite.Box.Height/4, 25, Sprite.Box.Height/2);
            this.attackBoxRight = new Rectangle(x + Sprite.Box.Width, y + Sprite.Box.Height / 4, 25, Sprite.Box.Height / 2);
            this.attackBoxUp = new Rectangle(x + Sprite.Box.Width/4, y - 25, Sprite.Box.Width/2, 25);
            this.attackBoxDown = new Rectangle(x + Sprite.Box.Width / 4, y + Sprite.Box.Height, Sprite.Box.Width / 2, 25);
            this.itemTimer = 0;
            this.NumRupees = 999; // for testing, remove l8r
            this.MaxHearts = 3.0;
            this.CurrentHearts = 3.0;
            this.origin = new Vector2(0, 0);
            this.NumberKeys = 1;
            this.pickedUpItem = new List<IItem>();
        }
    }
}
