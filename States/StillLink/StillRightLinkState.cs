using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class StillRightLinkState : ILinkState
    {
        private GreenLink link;

        public StillRightLinkState(GreenLink link)
        {
            this.link = link;
            this.link.direction = "right";
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
            link.state = new MovingRightLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRightWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
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
            //Nothing to do
        }

        public void Update()
        {
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }
    }
}
