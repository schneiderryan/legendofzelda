

namespace LegendOfZelda
{
    class ProjectileDownLinkState : GreenLinkState
    {
        public ProjectileDownLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownProjectileLinkSprite();
            this.link.Direction = "down";
        }

        public override void Attack()
        {
            link.State = new AttackingDownLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillDownLinkState(link);
        }

        public override void FireProjectile()
        {
            // Nothing to do
        }
    }
}
