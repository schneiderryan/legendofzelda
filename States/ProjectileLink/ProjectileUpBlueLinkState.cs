

namespace LegendOfZelda
{
    class ProjectileUpBlueLinkState : BlueLinkState
    {
        public ProjectileUpBlueLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueUpProjectileLinkSprite();
            link.Direction = "up";
        }

        public override void Attack()
        {
            link.State = new AttackingUpBlueLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillUpBlueLinkState(link);
        }

        public override void FireProjectile()
        {
            // nothing to do
        }
    }
}
