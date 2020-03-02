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
            this.link.direction = "right";
        }

        public void MoveUp()
        {
            link.state = new MovingUpRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveDown()
        {
            link.state = new MovingDownRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveRight()
        {
            //Nothing to do
        }

        public void MoveLeft()
        {
            link.state = new MovingLeftRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Attack()
        {
            link.state = new AttackingRightRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedRightAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.state = new StillRightRedLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedRightStillLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.X += 2;
            if (link.X > 800)
            {
                link.X -= 800;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
