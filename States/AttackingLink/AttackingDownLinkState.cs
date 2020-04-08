﻿

namespace LegendOfZelda
{
    class AttackingDownLinkState : AttackingGreenLinkState
    {
        public AttackingDownLinkState(IPlayer link) : base(link)
        {
            this.link.Direction = "down";
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownAttackingLinkSprite();
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
                link.State = new StillDownLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateDownStillLinkSprite();
            }
            base.Update();
        }
    }
}
