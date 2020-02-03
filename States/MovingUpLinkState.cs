using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class MovingUpLinkState : ILinkState
    {
        private Link link;

        public MovingUpLinkState(Link link)
        {
            this.link = link;
        }

        public void MoveUp()
        {
            //Nothing to do
        }

        public void MoveDown()
        {
            link.state = new MovingDownLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateDownWalkingLinkSprite();
        }

        public void MoveRight()
        {
            link.state = new MovingRightLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRightWalkingLinkSprite();
        }

        public void MoveLeft()
        {
            link.state = new MovingLeftLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateLeftWalkingLinkSprite();
        }

        public void Attack()
        {
            link.state = new AttackingLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateUpAttackingLinkSprite();
        }

        public void BeStill()
        {
            link.state = new StillLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
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
