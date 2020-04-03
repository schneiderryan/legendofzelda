

namespace LegendOfZelda
{
    class ProjectileDownRedLinkState : RedLinkState
    {
        public ProjectileDownRedLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownProjectileLinkSprite();
            link.Direction = "down";
        }

        public override void Attack()
        {
            link.State = new AttackingDownRedLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillDownRedLinkState(link);
        }

        public override void FireProjectile()
        {
            // nothing to do
        }
    }
}
