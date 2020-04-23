

namespace LegendOfZelda
{
    class StillDownBlueLinkState : BlueLinkState
    {
        public StillDownBlueLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueDownStillLinkSprite();
            link.Direction = "down";
        }

        public override void Attack()
        {
            link.State = new AttackingDownBlueLinkState(link);
        }

        public override void BeStill()
        {
            // do nothing
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileDownBlueLinkState(link);
        }
    }
}
