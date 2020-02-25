using Microsoft.Xna.Framework;
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
            link.state = new AttackingUpRedLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRedUpAttackingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.state = new StillUpRedLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.Y -= 2;
            if (link.Y < 0)
            {
                link.Y += 480;
            }
            link.sprite.Position = new Point(link.X, link.Y);
        }
    }
}
