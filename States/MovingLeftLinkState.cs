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
            //Nothing to do
        }

        public void Attack()
        {
            link.state = new AttackingLeftLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateLeftAttackingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void UseItem1()
        {
            link.game.projectiles.Add(new Projectile(ProjectileSpriteFactory.Instance.CreateLeftArrow(), new Vector2(link.xPos, link.yPos), new Vector2(-7, 0)));
        }

        public void BeStill()
        {
            link.state = new StillLeftLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateLeftStillLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.xPos -= 2;
            if (link.xPos < 0)
            {
                link.xPos += 800;
            }
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }
    }
}
