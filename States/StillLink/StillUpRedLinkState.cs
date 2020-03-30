using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class StillUpRedLinkState : ILinkState
    {
        private RedLink link;

        public StillUpRedLinkState(RedLink link)
        {
            this.link = link;
            this.link.Direction = "up";
        }

        public void MoveUp()
        {
            link.State = new MovingUpRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveDown()
        {
            link.State = new MovingDownRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
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
            link.State = new AttackingUpRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            //Nothing to do
        }

        public void PickupItem(int time)
        {
            //link.State = new LinkPickupState(link);
            //link.Sprite = PlayerSpriteFactory.Instance.CreateLinkPickup1();
            //link.Sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.Sprite.Position = new Point(link.X, link.Y);
        }

        public void Projectile()
        {
            link.State = new ProjectileUpRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpProjectileLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

    }
}
