using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AttackingRightLinkState : AttackingLinkState
    {
        private GreenLink link;
        public AttackingRightLinkState(GreenLink link)
        {
            this.link = link;
            this.link.direction = "right";
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.state = new StillRightLinkState(link);
                link.sprite = PlayerSpriteFactory.Instance.CreateRightStillLinkSprite();
            }
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }

    }
}
