

namespace LegendOfZelda
{
    class ProjectileDownBlueLinkState : BlueLinkState
    {
        public ProjectileDownBlueLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueDownProjectileLinkSprite();
            link.Direction = "down";
        }

        public override void Attack()
        {
            link.State = new AttackingDownBlueLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillDownBlueLinkState(link);
        }

        public override void FireProjectile()
        {
            // nothing to do
        }
    }
}
