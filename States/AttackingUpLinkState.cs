using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AttackingUpLinkState : ILinkState
    {
        private GreenLink link;
        public AttackingUpLinkState(GreenLink link)
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
            //Nothing to do
        }

        public void BeStill()
        {
            link.state = new StillUpLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }

        public void TakeDamage()
        {
            new DamagedLink(link, link.game);
        }
    }
}
