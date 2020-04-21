

namespace LegendOfZelda
{
    class StillRightBlueLinkState : BlueLinkState
    {
        public StillRightBlueLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueRightStillLinkSprite();
            link.Direction = "right";
        }

        public override void Attack()
        {
            link.State = new AttackingRightBlueLinkState(link);
        }

        public override void BeStill()
        {
            //Nothing to do
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileRightBlueLinkState(link);
        }
    }
}
