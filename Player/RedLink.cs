﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class RedLink : IPlayer
    {
        private IPlayer link;
        public RedLink(IPlayer link)
        {
            this.link = link;
            this.link.Color = "red";
            switch (link.Direction)
            {
                case "up":
                    link.State = new StillUpRedLinkState(this);
                    break;
                case "down":
                    link.State = new StillDownRedLinkState(this);
                    break;
                case "left":
                    link.State = new StillLeftRedLinkState(this);
                    break;
                case "right":
                    link.State = new StillRightRedLinkState(this);
                    break;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }

        public ILinkState State { get => link.State; set => link.State = value; }
        public string Direction { get => link.Direction; set => link.Direction = value; }
        public string Color { get => link.Color; set => link.Color = value; }
        public double MaxHearts { get => link.MaxHearts; set => link.MaxHearts = value; }
        public double CurrentHearts { get => link.CurrentHearts; set => link.CurrentHearts = value; }

        public IInventory Inventory => link.Inventory;

        public Rectangle Footbox => link.Footbox;

        public Rectangle UpAttackBox => link.UpAttackBox;

        public Rectangle DownAttackBox => link.DownAttackBox;

        public Rectangle RightAttackBox => link.RightAttackBox;

        public Rectangle LeftAttackBox => link.LeftAttackBox;

        public Point Center => link.Center;

        public Team Team { get => link.Team; set => link.Team = value; }
        public ISprite Sprite { get => link.Sprite; set => link.Sprite = value; }

        public Rectangle Hitbox => link.Hitbox;

        public int X { get => link.X; set => link.X = value; }
        public int Y { get => link.Y; set => link.Y = value; }

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

        public void RegisterAttackKeys(List<Keys> attackKeys)
        {
            link.RegisterAttackKeys(attackKeys);
        }

        public void TakeDamage(double amount)
        {
            link.TakeDamage(amount);
        }

        public void Update()
        {
            link.Update();
        }

        public void UseProjectile(IProjectile projectile)
        {
            link.UseProjectile(projectile);
        }

        public void WearBlueRing()
        {
            link.WearBlueRing();
        }

        public void WearRedRing()
        {
            // already wearing it
        }
    }
}
