using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AttackingUpRedLinkState : AttackingLinkState
    {
        private RedLink link;
        public AttackingUpRedLinkState(RedLink link)
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
                link.state = new StillUpRedLinkState(link);
                link.sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
            }
            link.sprite.Position = new Point(link.X, link.Y);
        }
    }
}
