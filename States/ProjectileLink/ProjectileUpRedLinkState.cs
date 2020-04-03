

namespace LegendOfZelda
{
    class ProjectileUpRedLinkState : RedLinkState
    {
        public ProjectileUpRedLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpProjectileLinkSprite();
            link.Direction = "up";
        }

        public override void Attack()
        {
            link.State = new AttackingUpRedLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillUpRedLinkState(link);
        }

        public override void FireProjectile()
        {
            // nothing to do
        }
    }
}
