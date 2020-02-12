﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class MovingLeftRedLinkState : ILinkState
    {
        private RedLink link;

        public MovingLeftRedLinkState(RedLink link)
        {
            this.link = link;
        }

        public void MoveUp()
        {
            link.state = new MovingUpRedLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRedUpWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void MoveDown()
        {
            link.state = new MovingDownRedLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRedDownWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void MoveRight()
        {
            link.state = new MovingRightRedLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRedRightWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void MoveLeft()
        {
            //Nothing to do
        }

        public void Attack()
        {
            link.state = new AttackingLeftRedLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRedLeftAttackingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void UseItem1()
        {
            link.game.projectiles.Add(new Projectile(ProjectileSpriteFactory.Instance.CreateLeftArrow(), new Vector2(link.xPos, link.yPos), new Vector2(-3, 0)));
        }

        public void BeStill()
        {
            link.state = new StillLeftRedLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRedLeftStillLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.xPos -= 2;
            if (link.xPos < 0)
            {
                link.xPos += 800;
            }
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }
    }
}
