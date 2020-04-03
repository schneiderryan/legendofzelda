

namespace LegendOfZelda
{
    class MovingLeftRedLinkState : RedLinkState
    {
        public MovingLeftRedLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftWalkingLinkSprite();
            link.Direction = "left";
            VX = -2;
            VY = 0;
        }

        public override void Attack()
        {
            link.State = new AttackingLeftRedLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillLeftRedLinkState(link);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileLeftRedLinkState(link);
        }

        public override void MoveLeft()
        {
            //Nothing to do
        }
    }
}
