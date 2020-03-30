

namespace LegendOfZelda
{
    abstract class DownRedLinkState : RedLinkState
    {
        public DownRedLinkState(RedLink link) : base(link)
        {
            link.Direction = "down";
        }

        public override void Attack()
        {
            link.State = new AttackingDownRedLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillDownRedLinkState(link);
        }

        public override void Projectile()
        {
            link.State = new ProjectileDownRedLinkState(link);
        }
    }
}
