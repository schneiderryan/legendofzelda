using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class MovingDownLinkState : ILinkState
    {
        private Link link;

        public MovingDownLinkState(Link link)
        {
            this.link = link;
        }

        public void MoveUp()
        {
            link.state = new MovingUpLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateUpWalkingLinkSprite();
        }

        public void MoveDown()
        {
            //Nothing to do
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
            link.sprite = PlayerSpriteFactory.Instance.CreateDownAttackingLinkSprite();
        }

        public void BeStill()
        {
            link.state = new StillLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateDownStillLinkSprite();
        }

        public void Update()
        {
            link.yPos += 2;
            if (link.yPos > 480)
            {
                link.yPos -= 480;
            }
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }
    }
}
