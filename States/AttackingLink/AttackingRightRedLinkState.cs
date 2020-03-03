using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class AttackingRightRedLinkState : AttackingLinkState
    {
        private RedLink link;
        public AttackingRightRedLinkState(RedLink link)
        {
            this.link = link;
            this.link.Direction = "right";
        }

        public override void Attack()
        {
            this.link.UseProjectile(new SwordProjectile("right", this.link.X, this.link.Y));
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillRightRedLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateRedRightStillLinkSprite();
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }

    }
}
