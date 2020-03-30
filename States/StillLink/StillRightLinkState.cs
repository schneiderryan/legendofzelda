using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class StillRightLinkState : ILinkState
    {
        private GreenLink link;

        public StillRightLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "right";
        }

        public void MoveUp()
        {
            link.State = new MovingUpLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveDown()
        {
            link.State = new MovingDownLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveRight()
        {
            link.State = new MovingRightLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveLeft()
        {
            link.State = new MovingLeftLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Attack()
        {
            link.State = new AttackingRightLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            //Nothing to do
        }

        public void PickupItem(int time)
        {
            link.State = new LinkPickupState(link, time);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLinkPickup1();
            link.Sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.Sprite.Position = new Point(link.X, link.Y);
        }
        public void Projectile()
        {
            link.State = new ProjectileRightLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightProjectileLinkSprite();
            link.Sprite.Scale = 2.0f;
        }
    }
}
