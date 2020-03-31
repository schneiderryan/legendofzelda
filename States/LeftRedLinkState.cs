

namespace LegendOfZelda
{
    abstract class LeftRedLinkState : RedLinkState
    {
        public LeftRedLinkState(RedLink link) : base(link)
        {
            link.Direction = "left";
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
    }
}
