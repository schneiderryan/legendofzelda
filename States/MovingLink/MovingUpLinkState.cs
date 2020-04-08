

namespace LegendOfZelda
{
    class MovingUpLinkState : GreenLinkState
    {
        public MovingUpLinkState(IPlayer link) : base(link)
        {
            this.link.Direction = "up";
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpWalkingLinkSprite();
            VY = -2;
            VX = 0;
        }

        public override void MoveUp()
        {
            //Nothing to do
        }

        public override void Attack()
        {
            link.State = new AttackingUpLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillUpLinkState(link);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileUpLinkState(link);
        }
    }
}
