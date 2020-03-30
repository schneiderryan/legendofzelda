﻿using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    internal class ProjectileLeftLinkState : ILinkState
    {
        private GreenLink link;

        public ProjectileLeftLinkState(GreenLink link)
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
            link.State = new AttackingDownLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.State = new StillLeftLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftStillLinkSprite();
            link.Sprite.Scale = 2f;
        }

        public void Update()
        {
            link.Sprite.Position = new Point(link.X, link.Y);
        }

        public void Projectile()
        {

        }
    }
}
