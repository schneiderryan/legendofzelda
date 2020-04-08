

namespace LegendOfZelda
{
    class StillRightLinkState : GreenLinkState
    {
        public StillRightLinkState(IPlayer link) : base(link)
        {
            this.link.Direction = "right";
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightStillLinkSprite();
        }

        public override void Attack()
        {
            link.State = new AttackingRightLinkState(link);
        }

        public override void BeStill()
        {
            //Nothing to do
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileRightLinkState(link);
        }
    }
}
