using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    internal class StillLeftLinkState : ILinkState
    {
        private GreenLink link;

        public StillLeftLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "left";
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
            link.State = new AttackingLeftLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            //Nothing to do
        }

        public void Update()
        {
            link.Sprite.Position = new Point(link.X, link.Y);
        }

        public void Projectile()
        {
            link.State = new ProjectileLeftLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftProjectileLinkSprite();
            link.Sprite.Scale = 2.0f;
        }
    }
}