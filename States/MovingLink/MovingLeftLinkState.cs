using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class MovingLeftLinkState : ILinkState
    {
        private GreenLink link;

        public MovingLeftLinkState(GreenLink link)
        {
            this.link = link;
            this.link.direction = "left";
        }

        public void MoveUp()
        {
            link.state = new MovingUpLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveDown()
        {
            link.state = new MovingDownLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveRight()
        {
            link.state = new MovingRightLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveLeft()
        {
            //Nothing to do
        }

        public void Attack()
        {
            link.state = new AttackingLeftLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.state = new StillLeftLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftStillLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.X -= 2;
            if (link.X < 0)
            {
                link.X += 800;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
