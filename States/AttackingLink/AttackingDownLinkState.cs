using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class AttackingDownLinkState : AttackingLinkState
    {
        private GreenLink link;
        public AttackingDownLinkState(GreenLink link)
        {
            this.link = link;
            this.link.direction = "down";
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.state = new StillDownLinkState(link);
                link.sprite = PlayerSpriteFactory.Instance.CreateDownStillLinkSprite();
            }
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }
    }
}
