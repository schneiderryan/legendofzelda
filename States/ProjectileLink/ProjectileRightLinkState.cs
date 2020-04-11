

namespace LegendOfZelda
{
    internal class ProjectileRightLinkState : GreenLinkState
    {
        public ProjectileRightLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightProjectileLinkSprite();
            this.link.Direction = "right";
        }

        public override void Attack()
        {
            link.State = new AttackingRightLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillRightLinkState(link);
        }

        public override void FireProjectile()
        {
            // nothing needed
        }
    }
}
