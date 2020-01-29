using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class StillLinkState : ILinkState
    {
        private Link link;

        public StillLinkState(Link link)
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
            //set sprite depending on direction
        }

        public void BeStill()
        {
            //Nothing to do
        }

        public void Update()
        {
            //Nothing to do
        }
    }
}
