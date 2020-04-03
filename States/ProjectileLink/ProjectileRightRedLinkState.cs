

namespace LegendOfZelda
{
    class ProjectileRightRedLinkState : RedLinkState
    {
        public ProjectileRightRedLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedRightProjectileLinkSprite();
            link.Direction = "right";
        }

        public override void Attack()
        {
            link.State = new AttackingRightRedLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillRightRedLinkState(link);
        }

        public override void FireProjectile()
        {
            //Nothing to do
        }
    }
}
