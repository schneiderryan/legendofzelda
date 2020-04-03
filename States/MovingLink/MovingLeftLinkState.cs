

namespace LegendOfZelda
{
    class MovingLeftLinkState : GreenLinkState
    {
        public MovingLeftLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftWalkingLinkSprite();
            link.Direction = "left";
            VX = -2;
            VY = 0;
        }

        public override void MoveLeft()
        {
            //Nothing to do
        }

        public override void Attack()
        {
            link.State = new AttackingLeftLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillLeftLinkState(link);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileLeftLinkState(link);
        }
    }
}
