

namespace LegendOfZelda
{
    class StillLeftLinkState : GreenLinkState
    {
        public StillLeftLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftStillLinkSprite();
            this.link.Direction = "left";
        }

        public override void Attack()
        {
            link.State = new AttackingLeftLinkState(link);
        }

        public override void BeStill()
        {
            //Nothing to do
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileLeftLinkState(link);
        }
    }
}