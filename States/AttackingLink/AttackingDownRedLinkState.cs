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
                link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownStillLinkSprite();
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
