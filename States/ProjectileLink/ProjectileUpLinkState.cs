

namespace LegendOfZelda
{
    internal class ProjectileUpLinkState : GreenLinkState
    {
        public ProjectileUpLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpProjectileLinkSprite();
            this.link.Direction = "up";
        }

        public override void Attack()
        {
            link.State = new AttackingUpLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillUpLinkState(link);
        }

        public override void FireProjectile()
        {
            // nothing needed
        }
    }
}
