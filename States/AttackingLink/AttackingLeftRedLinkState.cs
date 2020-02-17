using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class AttackingLeftRedLinkState : AttackingLinkState
    {
        private RedLink link;
        public AttackingLeftRedLinkState(RedLink link)
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
                link.state = new StillLeftRedLinkState(link);
                link.sprite = PlayerSpriteFactory.Instance.CreateRedLeftStillLinkSprite();
            }
            link.sprite.Position = new Point(link.xPos, link.yPos);
        }
    }
}
