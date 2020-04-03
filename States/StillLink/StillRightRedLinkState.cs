

namespace LegendOfZelda
{
    class StillRightRedLinkState : RedLinkState
    {
        public StillRightRedLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedRightStillLinkSprite();
            link.Direction = "right";
        }

        public override void Attack()
        {
            link.State = new AttackingRightRedLinkState(link);
        }

        public override void BeStill()
        {
            //Nothing to do
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileRightRedLinkState(link);
        }
    }
}
