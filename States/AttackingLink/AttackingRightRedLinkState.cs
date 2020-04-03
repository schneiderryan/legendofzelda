

namespace LegendOfZelda
{
    class AttackingRightRedLinkState : AttackingRedLinkState
    {
        public AttackingRightRedLinkState(IPlayer link) : base(link)
        {
            this.link.Direction = "right";
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedRightAttackingLinkSprite();
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
            base.Update();
        }

    }
}
