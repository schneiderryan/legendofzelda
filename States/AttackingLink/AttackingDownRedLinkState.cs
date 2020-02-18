using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AttackingDownRedLinkState : AttackingLinkState
    {
        private RedLink link;
        public AttackingDownRedLinkState(RedLink link)
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
                link.state = new StillDownRedLinkState(link);
                link.sprite = PlayerSpriteFactory.Instance.CreateRedDownStillLinkSprite();
            }
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }
    }
}
