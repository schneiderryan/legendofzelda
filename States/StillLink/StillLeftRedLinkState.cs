

namespace LegendOfZelda
{
    class StillLeftRedLinkState : RedLinkState
    {
        public StillLeftRedLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftStillLinkSprite();
            link.Direction = "left";
        }

        public override void Attack()
        {
            link.State = new AttackingLeftRedLinkState(link);
        }

        public override void BeStill()
        {
            //Nothing to do
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileLeftRedLinkState(link);
        }
    }
}
