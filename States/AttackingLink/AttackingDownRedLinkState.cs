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
            this.link.Direction = "down";
        }

        public override void Attack()
        {
            this.link.UseProjectile(new SwordProjectile("down", this.link.X, this.link.Y));
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillDownRedLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownStillLinkSprite();
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
