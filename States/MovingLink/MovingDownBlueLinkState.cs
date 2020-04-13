

namespace LegendOfZelda
{
    class MovingDownBlueLinkState : BlueLinkState
    {
        public MovingDownBlueLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueDownWalkingLinkSprite();
            link.Direction = "down";
            VY = 2;
            VX = 0;
        }

        public override void Attack()
        {
            link.State = new AttackingDownBlueLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillDownBlueLinkState(link);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileDownBlueLinkState(link);
        }

        public override void MoveDown()
        {
            //Nothing to do
        }

    }
}
