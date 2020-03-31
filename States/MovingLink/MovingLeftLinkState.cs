﻿using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class MovingLeftLinkState : GreenLinkState
    {
        public MovingLeftLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "left";
        }

        public override void MoveUp()
        {
            link.State = new MovingUpLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void MoveDown()
        {
            link.State = new MovingDownLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void MoveRight()
        {
            link.State = new MovingRightLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void MoveLeft()
        {
            //Nothing to do
        }

        public override void Attack()
        {
            link.State = new AttackingLeftLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void BeStill()
        {
            link.State = new StillLeftLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftStillLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void Update()
        {
            link.X -= 2;
            if (link.X < 0)
            {
                link.X += 800;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileLeftLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftProjectileLinkSprite();
            link.Sprite.Scale = 2.0f;
        }
    }
}
