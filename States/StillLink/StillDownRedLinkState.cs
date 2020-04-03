

namespace LegendOfZelda
{
    class StillDownRedLinkState : RedLinkState
    {
        public StillDownRedLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownStillLinkSprite();
            link.Direction = "down";
        }

        public override void Attack()
        {
            link.State = new AttackingDownRedLinkState(link);
        }

        public override void BeStill()
        {
            // do nothing
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileDownRedLinkState(link);
        }
    }
}
