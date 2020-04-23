

namespace LegendOfZelda
{
    class StillUpBlueLinkState : BlueLinkState
    {
        public StillUpBlueLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueUpStillLinkSprite();
            link.Direction = "up";
        }

        public override void Attack()
        {
            link.State = new AttackingUpBlueLinkState(link);
        }

        public override void BeStill()
        {
            //Nothing to do
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileUpBlueLinkState(link);
        }
    }
}
