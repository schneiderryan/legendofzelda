using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class MovingUpLinkState : ILinkState
    {
        private GreenLink link;

        public MovingUpLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "up";
        }

        public void MoveUp()
        {
            //Nothing to do
        }

        public void MoveDown()
        {
            link.State = new MovingDownLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveRight()
        {
            link.State = new MovingRightLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveLeft()
        {
            link.State = new MovingLeftLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Attack()
        {
            link.State = new AttackingUpLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.State = new StillUpLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.Y -= 2;
            if (link.Y < 0)
            {
                link.Y += 480;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
