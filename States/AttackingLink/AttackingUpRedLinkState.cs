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
            this.link.Direction = "up";
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillUpRedLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
