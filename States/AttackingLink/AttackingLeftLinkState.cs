using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AttackingLeftLinkState : AttackingLinkState
    {
        GreenLink link;
        public AttackingLeftLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "left";
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillLeftLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateLeftStillLinkSprite();
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
