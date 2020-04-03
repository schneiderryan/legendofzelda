

namespace LegendOfZelda
{
    class MovingUpRedLinkState : RedLinkState
    {
        public MovingUpRedLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpWalkingLinkSprite();
            link.Direction = "up";
            VY = -2;
            VX = 0;
        }

        public override void Attack()
        {
            link.State = new AttackingUpRedLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillUpRedLinkState(link);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileUpRedLinkState(link);
        }

        public override void MoveUp()
        {
            //Nothing to do
        }
    }
}
