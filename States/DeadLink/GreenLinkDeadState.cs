using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class GreenLinkDeadState : LinkDeadState
    {
        private ISprite LinkUp;
        private ISprite LinkDown;
        private ISprite LinkRight;
        private ISprite LinkLeft;
        private ISprite Despawn;
        public GreenLinkDeadState(IPlayer link) : base(link)
        {
            link.Sprite.Position = new Point(link.X, link.Y);
            LinkUp = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            LinkDown = PlayerSpriteFactory.Instance.CreateDownStillLinkSprite();
            LinkRight = PlayerSpriteFactory.Instance.CreateRightStillLinkSprite();
            LinkLeft = PlayerSpriteFactory.Instance.CreateLeftStillLinkSprite();
            Despawn = EnemySpriteFactory.Instance.CreateDeadEnemy();
            link.Sprite = LinkDown;
        }

        public override void Update()
        {
            if (flashTimer > 0 && flashDelay == 0)
            {
                if (link.DeadColor.Equals(Color.White))
                {
                    link.DeadColor = Color.Orange;
                }
                else
                {
                    link.DeadColor = Color.White;
                }
                flashDelay = FLASH_DELAY;
                spinDelay = SPIN_DELAY;
            } else if (rotations > 0 && spinDelay == 0)
            {
                if (link.Direction.Equals("down"))
                {
                    link.Sprite = LinkRight;
                    link.Direction = "right";
                } else if (link.Direction.Equals("right"))
                {
                    link.Sprite = LinkUp;
                    link.Direction = "up";
                } else if (link.Direction.Equals("up"))
                {
                    link.Sprite = LinkLeft;
                    link.Direction = "left";
                }
                else
                {
                    link.Sprite = LinkDown;
                    link.Direction = "down";
                    rotations--;
                }
                spinDelay = SPIN_DELAY;
            } else if (rotations == 0)
            {
                link.Sprite = Despawn;
            }
            if(rotations <= 0)
            {
                despawnTimer--;
            }
            if(despawnTimer == 0)
            {
                link.DeadColor = Color.Black;
            }
            flashTimer--;
            flashDelay--;
            spinDelay--;

            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
