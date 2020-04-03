

namespace LegendOfZelda
{
    internal class ProjectileLeftLinkState : GreenLinkState
    {
        public ProjectileLeftLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftProjectileLinkSprite();
            this.link.Direction = "left";
        }

        public override void Attack()
        {
            link.State = new AttackingDownLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillLeftLinkState(link);
        }

        public override void FireProjectile()
        {
            // nothing to do
        }
    }
}
