using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AttackingDownLinkState : AttackingLinkState
    {
        private GreenLink link;
        public AttackingDownLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "down";
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillDownLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateDownStillLinkSprite();
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
