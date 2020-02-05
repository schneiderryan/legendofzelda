using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Text;

namespace Sprint0
{
    class MovingRightLinkState : ILinkState
    {
        private GreenLink link;

        public MovingRightLinkState(GreenLink link)
        {
            this.link = link;
        }

        public void MoveUp()
        {
            link.state = new MovingUpLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateUpWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void MoveDown()
        {
            link.state = new MovingDownLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateDownWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void MoveRight()
        {
            //Nothing to do
        }

        public void MoveLeft()
        {
            link.state = new MovingLeftLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateLeftWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void Attack()
        {
            link.state = new AttackingRightLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRightAttackingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.state = new StillRightLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRightStillLinkSprite();
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
