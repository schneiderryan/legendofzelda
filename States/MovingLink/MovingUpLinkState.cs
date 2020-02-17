﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class MovingUpLinkState : ILinkState
    {
        private GreenLink link;

        public MovingUpLinkState(GreenLink link)
        {
            this.link = link;
            this.link.direction = "up";
        }

        public void MoveUp()
        {
            //Nothing to do
        }

        public void MoveDown()
        {
            link.state = new MovingDownLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateDownWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void MoveRight()
        {
            link.state = new MovingRightLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRightWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void MoveLeft()
        {
            link.state = new MovingLeftLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateLeftWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void Attack()
        {
            link.state = new AttackingUpLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateUpAttackingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.state = new StillUpLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.yPos -= 2;
            if (link.yPos < 0)
            {
                link.yPos += 480;
            }
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }
    }
}
