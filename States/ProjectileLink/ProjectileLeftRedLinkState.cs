

namespace LegendOfZelda
{
    class ProjectileLeftRedLinkState : RedLinkState
    {
        public ProjectileLeftRedLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftProjectileLinkSprite();
            link.Direction = "left";
        }

        public override void Attack()
        {
            link.State = new AttackingLeftRedLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillLeftRedLinkState(link);
        }

        public override void FireProjectile()
        {
            //Nothing to do
        }
    }
}
