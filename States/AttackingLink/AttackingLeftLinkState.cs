using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class AttackingLeftLinkState : AttackingLinkState
    {
        GreenLink link;
        public AttackingLeftLinkState(GreenLink link)
        {
            this.link = link;
            this.link.direction = "left";
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.state = new StillLeftLinkState(link);
                link.sprite = PlayerSpriteFactory.Instance.CreateLeftStillLinkSprite();
            }
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }
    }
}
