

namespace LegendOfZelda
{
    class MovingLeftBlueLinkState : BlueLinkState
    {
        public MovingLeftBlueLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueLeftWalkingLinkSprite();
            link.Direction = "left";
            VX = -2;
            VY = 0;
        }

        public override void Attack()
        {
            link.State = new AttackingLeftBlueLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillLeftBlueLinkState(link);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileLeftBlueLinkState(link);
        }

        public override void MoveLeft()
        {
            //Nothing to do
        }
    }
}
