

namespace LegendOfZelda
{
    class StillUpRedLinkState : RedLinkState
    {
        public StillUpRedLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
            link.Direction = "up";
        }

        public override void Attack()
        {
            link.State = new AttackingUpRedLinkState(link);
        }

        public override void BeStill()
        {
            //Nothing to do
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileUpRedLinkState(link);
        }
    }
}
