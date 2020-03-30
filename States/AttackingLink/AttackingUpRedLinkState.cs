﻿using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class AttackingUpRedLinkState : AttackingLinkState
    {
        private RedLink link;
        public AttackingUpRedLinkState(RedLink link)
        {
            this.link = link;
            this.link.Direction = "up";
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpAttackingLinkSprite();
            // adjust for the presence of the sword in the sprite
            link.Sprite.Position = new Point(link.X, link.Y - 24);
        }

        public override void Attack()
        {
            this.link.UseProjectile(new SwordProjectile("up", this.link.X, this.link.Y));
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
                link.Sprite.Position = new Point(link.X, link.Y);
            }
        }
    }
}
