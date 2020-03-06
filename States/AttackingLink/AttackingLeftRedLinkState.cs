using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AttackingLeftRedLinkState : AttackingLinkState
    {
        private RedLink link;
        public AttackingLeftRedLinkState(RedLink link)
        {
            this.link = link;
            this.link.Direction = "left";
        }

        public override void Attack()
        {
            this.link.UseProjectile(new SwordProjectile("left", this.link.X, this.link.Y));
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillLeftRedLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftStillLinkSprite();
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
