

namespace LegendOfZelda
{
    class ProjectileRightBlueLinkState : BlueLinkState
    {
        public ProjectileRightBlueLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueRightProjectileLinkSprite();
            link.Direction = "right";
        }

        public override void Attack()
        {
            link.State = new AttackingRightBlueLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillRightBlueLinkState(link);
        }

        public override void FireProjectile()
        {
            //Nothing to do
        }
    }
}
