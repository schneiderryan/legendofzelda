

namespace LegendOfZelda
{
    class MovingDownLinkState : GreenLinkState
    {
        public MovingDownLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownWalkingLinkSprite();
            this.link.Direction = "down";
            VX = 0;
            VY = 2;
        }

        public override void MoveDown()
        {
            //Nothing to do
        }

        public override void Attack()
        {
            link.State = new AttackingDownLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillDownLinkState(link);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileDownLinkState(link);
        }
    }
}
