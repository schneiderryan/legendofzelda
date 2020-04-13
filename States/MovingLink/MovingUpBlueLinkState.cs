

namespace LegendOfZelda
{
    class MovingUpBlueLinkState : BlueLinkState
    {
        public MovingUpBlueLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueUpWalkingLinkSprite();
            link.Direction = "up";
            VY = -2;
            VX = 0;
        }

        public override void Attack()
        {
            link.State = new AttackingUpBlueLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillUpBlueLinkState(link);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileUpBlueLinkState(link);
        }

        public override void MoveUp()
        {
            //Nothing to do
        }
    }
}
