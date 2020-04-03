

namespace LegendOfZelda
{
    class MovingRightRedLinkState : RedLinkState
    {
        public MovingRightRedLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedRightWalkingLinkSprite();
            link.Direction = "right";
            VY = 0;
            VX = 2;
        }

        public override void Attack()
        {
            link.State = new AttackingRightRedLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillRightRedLinkState(link);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileRightRedLinkState(link);
        }

        public override void MoveRight()
        {
            //Nothing to do
        }
    }
}
