

namespace LegendOfZelda
{
    class GrabbedLinkState : GreenLinkState
    {
        public GrabbedLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftStillLinkSprite();
            //this.link.Direction = "left";
        }

        public override void Attack()
        {
            //
        }

        public override void BeStill()
        {
            //Nothing to do
        }

        public override void FireProjectile()
        {
            //
        }
    }
}