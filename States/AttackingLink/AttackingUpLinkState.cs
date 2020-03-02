using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AttackingUpLinkState : AttackingLinkState
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
                link.Sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }

    }
}
