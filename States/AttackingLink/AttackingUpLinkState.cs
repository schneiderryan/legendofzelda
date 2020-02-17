using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class AttackingUpLinkState : AttackingLinkState
    {
        private GreenLink link;
        public AttackingUpLinkState(GreenLink link)
        {
            this.link = link;
            this.link.direction = "up";
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.state = new StillUpLinkState(link);
                link.sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            }
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }

    }
}
