using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Text;

namespace Sprint0
{
    class MovingRightLinkState : ILinkState
    {
        private Link link;

        public MovingRightLinkState(Link link)
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
            link.state = new MovingDownLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateDownWalkingLinkSprite();
        }

        public void MoveRight()
        {
            //Nothing to do
        }

        public void MoveLeft()
        {
            link.state = new MovingLeftLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateLeftWalkingLinkSprite();
        }

        public void Attack()
        {
            link.state = new AttackingLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRightAttackingLinkSprite();
        }

        public void BeStill()
        {
            link.state = new StillLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRightStillLinkSprite();
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
