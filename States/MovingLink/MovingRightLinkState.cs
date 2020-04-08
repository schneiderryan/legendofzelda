

namespace LegendOfZelda
{
    class MovingRightLinkState : GreenLinkState
    {
        public MovingRightLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightWalkingLinkSprite();
            this.link.Direction = "right";
            VX = 2;
            VY = 0;
        }

        public override void MoveRight()
        {
            //Nothing to do
        }

        public override void Attack()
        {
            link.State = new AttackingRightLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillRightLinkState(link);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileRightLinkState(link);
        }
    }
}
