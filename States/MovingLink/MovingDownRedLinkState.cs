using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class MovingDownRedLinkState : ILinkState
    {
        private RedLink link;

        public MovingDownRedLinkState(RedLink link)
        {
            this.link = link;
            this.link.direction = "down";
        }

        public void MoveUp()
        {
            link.state = new MovingUpRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveDown()
        {
            //Nothing to do
        }

        public void MoveRight()
        {
            link.state = new MovingRightRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedRightWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveLeft()
        {
            link.state = new MovingLeftRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Attack()
        {
            link.state = new AttackingDownRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.state = new StillDownRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownStillLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.Y += 2;
            if (link.Y > 480)
            {
                link.Y -= 480;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
