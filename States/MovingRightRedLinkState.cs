using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Text;

namespace LegendOfZelda
{
    class MovingRightRedLinkState : ILinkState
    {
        private RedLink link;

        public MovingRightRedLinkState(RedLink link)
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
            //Nothing to do
        }

        public void MoveLeft()
        {
            link.state = new MovingLeftRedLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRedLeftWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void Attack()
        {
            link.state = new AttackingRightRedLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRedRightAttackingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.state = new StillRightRedLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRedRightStillLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.xPos += 2;
            if (link.xPos > 800)
            {
                link.xPos -= 800;
            }
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }
    }
}
