using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class BlueLink : IPlayer
    {
        private IPlayer link;
        public BlueLink(IPlayer link)
        {
            this.link = link;
            this.link.Color = "blue";
            switch (link.Direction)
            {
                case "up":
                    link.State = new StillUpBlueLinkState(this);
                    break;
                case "down":
                    link.State = new StillDownBlueLinkState(this);
                    break;
                case "left":
                    link.State = new StillLeftBlueLinkState(this);
                    break;
                case "right":
                    link.State = new StillRightBlueLinkState(this);
                    break;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
            link.Resistance = 0.50;
        }

        public ILinkState State { get => link.State; set => link.State = value; }
        public string Direction { get => link.Direction; set => link.Direction = value; }
        public string Color { get => link.Color; set => link.Color = value; }
        public double MaxHearts { get => link.MaxHearts; set => link.MaxHearts = value; }
        public double CurrentHearts { get => link.CurrentHearts; set => link.CurrentHearts = value; }
        public Color DeadColor { get => link.DeadColor; set => link.DeadColor = value; }

        public IInventory Inventory => link.Inventory;

        public Rectangle Footbox => link.Footbox;

        public Rectangle UpAttackBox => link.UpAttackBox;

        public Rectangle DownAttackBox => link.DownAttackBox;

        public Rectangle RightAttackBox => link.RightAttackBox;

        public Rectangle LeftAttackBox => link.LeftAttackBox;

        public Point Center => link.Center;

        public bool HeartsCanChange { get => link.HeartsCanChange; set => link.HeartsCanChange = value; }
        public Team Team { get => link.Team; set => link.Team = value; }
        public ISprite Sprite { get => link.Sprite; set => link.Sprite = value; }

        public Rectangle Hitbox => link.Hitbox;

        public int X { get => link.X; set => link.X = value; }
        public int Y { get => link.Y; set => link.Y = value; }
        public IItem HeldItem { get => link.HeldItem; set => link.HeldItem = value; }
        public IItem CurrentItem { get => link.CurrentItem; set => link.CurrentItem = value; }
        public double Resistance { get => link.Resistance; set => link.Resistance = value; }
        public bool usedinRoom { get => link.usedinRoom; set => link.usedinRoom = value; }

        public void Attack()
        {
            link.Attack();
        }

        public void BeStill()
        {
            link.BeStill();
        }

        public void Draw(SpriteBatch sb, Color color)
        {
            link.Draw(sb, color);
        }

        public bool IsAttacking()
        {
            return link.IsAttacking();
        }

        public void Knockback(int amountX, int amountY)
        {
            link.Knockback(amountX, amountY);
        }

        public void MoveDown()
        {
            link.MoveDown();
        }

        public void MoveLeft()
        {
            link.MoveLeft();
        }

        public void MoveRight()
        {
            link.MoveRight();
        }

        public void MoveUp()
        {
            link.MoveUp();
        }

        public void PickupItem(IItem item, int time, bool twoHands = true)
        {
            link.PickupItem(item, time, twoHands);
        }

        public void TakeDamage(double amount)
        {
            this.link.TakeDamage(amount);
        }

        public void Update()
        {
            link.Update();
        }

        public void UseProjectile(IProjectile projectile)
        {
            link.UseProjectile(projectile);
        }
    }
}
