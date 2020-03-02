﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class MovingUpRedLinkState : ILinkState
    {
        private RedLink link;

        public MovingUpRedLinkState(RedLink link)
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
            link.state = new MovingDownRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveRight()
        {
            link.state = new MovingRightRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedRightWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveLeft()
        {
            link.state = new MovingLeftRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Attack()
        {
            link.state = new AttackingUpRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.state = new StillUpRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.Y -= 2;
            if (link.Y < 0)
            {
                link.Y += 480;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
