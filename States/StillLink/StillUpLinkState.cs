

namespace LegendOfZelda
{
    class StillUpLinkState : GreenLinkState
    {
        public StillUpLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            this.link.Direction = "up";
        }


        public override void Attack()
        {
            link.State = new AttackingUpLinkState(link);
        }

        public override void BeStill()
        {
            //Nothing to do
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileUpLinkState(link);
        }
    }
}
