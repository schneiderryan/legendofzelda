using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class MovingDownRedLinkState : ILinkState
    {
        private RedLink link;

        public MovingDownRedLinkState(RedLink link)
        {
            this.link = link;
            this.link.Direction = "down";
        }

        public void MoveUp()
        {
            link.State = new MovingUpRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveDown()
        {
            //Nothing to do
        }

        public void MoveRight()
        {
            link.State = new MovingRightRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedRightWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveLeft()
        {
            link.State = new MovingLeftRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Attack()
        {
            link.State = new AttackingDownRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.State = new StillDownRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownProjectileLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void PickupItem(int time)
        {
            //link.State = new LinkPickupState(link);
            //link.Sprite = PlayerSpriteFactory.Instance.CreateLinkPickup1();
            //link.Sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.Y += 2;
            if (link.Y > 480)
            {
                link.Y -= 480;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }

        public void Projectile()
        {
            link.State = new ProjectileDownRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownProjectileLinkSprite();
            link.Sprite.Scale = 2.0f;
        }
    }
}
