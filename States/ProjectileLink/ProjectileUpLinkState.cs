﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    internal class ProjectileUpLinkState : ILinkState
    {
        private GreenLink link;

        public ProjectileUpLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "up";
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
            link.State = new StillUpLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
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
