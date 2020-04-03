

namespace LegendOfZelda
{
    class MovingDownRedLinkState : RedLinkState
    {
        public MovingDownRedLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownWalkingLinkSprite();
            link.Direction = "down";
            VY = 2;
            VX = 0;
        }

        public override void Attack()
        {
            link.State = new AttackingDownRedLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillDownRedLinkState(link);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileDownRedLinkState(link);
        }

        public override void MoveDown()
        {
            //Nothing to do
        }

    }
}
