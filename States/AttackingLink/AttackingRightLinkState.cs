using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AttackingRightLinkState : AttackingLinkState
    {
        private GreenLink link;
        public AttackingRightLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "right";
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillRightLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateRightStillLinkSprite();
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }

    }
}
