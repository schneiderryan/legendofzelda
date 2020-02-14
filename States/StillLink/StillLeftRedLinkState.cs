﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    internal class StillLeftRedLinkState : ILinkState
    {
        private RedLink link;

        public StillLeftRedLinkState(RedLink link)
        {
            this.link = link;
            this.link.direction = "left";
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
            link.state = new MovingLeftRedLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRedLeftWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void Attack()
        {
            link.state = new AttackingLeftRedLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRedLeftAttackingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            //Nothing to do
        }

        public void Update()
        {
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }
    }
}