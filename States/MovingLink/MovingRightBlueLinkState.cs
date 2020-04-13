

namespace LegendOfZelda
{
    class MovingRightBlueLinkState : BlueLinkState
    {
        public MovingRightBlueLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueRightWalkingLinkSprite();
            link.Direction = "right";
            VY = 0;
            VX = 2;
        }

        public override void Attack()
        {
            link.State = new AttackingRightBlueLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillRightBlueLinkState(link);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileRightBlueLinkState(link);
        }

        public override void MoveRight()
        {
            //Nothing to do
        }
    }
}
