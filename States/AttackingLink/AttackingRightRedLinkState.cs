using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class AttackingRightRedLinkState : AttackingLinkState
    {
        private RedLink link;
        public AttackingRightRedLinkState(RedLink link)
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
                link.state = new StillRightRedLinkState(link);
                link.sprite = PlayerSpriteFactory.Instance.CreateRedRightStillLinkSprite();
            }
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }

    }
}
