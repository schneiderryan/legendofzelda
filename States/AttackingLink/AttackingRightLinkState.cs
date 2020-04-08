

namespace LegendOfZelda
{
    class AttackingRightLinkState : AttackingGreenLinkState
    {
        public AttackingRightLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightAttackingLinkSprite();
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
                link.State = new StillRightLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateRightStillLinkSprite();
            }
            base.Update();
        }

    }
}
