using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AttackingDownRedLinkState : ILinkState
    {
        private RedLink link;
        public AttackingDownRedLinkState(RedLink link)
        {
            this.link = link;
            this.link.direction = "down";
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
            //Nothing to do
        }

        public void BeStill()
        {
            link.state = new StillDownRedLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRedDownStillLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }
    }
}
