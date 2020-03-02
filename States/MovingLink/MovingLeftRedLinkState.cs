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
            this.link.direction = "left";
        }

        public void MoveUp()
        {
            link.state = new MovingUpRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
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
            //Nothing to do
        }

        public void Attack()
        {
            link.state = new AttackingLeftRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.state = new StillLeftRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftStillLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.X -= 2;
            if (link.X < 0)
            {
                link.X += 800;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
