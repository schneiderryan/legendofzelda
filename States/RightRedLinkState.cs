

namespace LegendOfZelda
{
    abstract class RightRedLinkState : RedLinkState
    {
        public RightRedLinkState(RedLink link) : base(link)
        {
            link.Direction = "right";
        }

        public override void Attack()
        {
            link.State = new AttackingRightRedLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillRightRedLinkState(link);
        }

        public override void Projectile()
        {
            link.State = new ProjectileRightRedLinkState(link);
        }
    }
}
