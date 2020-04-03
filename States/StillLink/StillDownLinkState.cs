

namespace LegendOfZelda
{
    internal class StillDownLinkState : GreenLinkState
    {
        public StillDownLinkState(IPlayer link) : base(link)
        {
            this.link = link;
            this.link.Direction = "down";
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownStillLinkSprite();
        }

        public override void Attack()
        {
            link.State = new AttackingDownLinkState(link);
        }

        public override void BeStill()
        {
            //Nothing to do
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileDownLinkState(link);
        }
    }
}
