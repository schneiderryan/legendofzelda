

namespace LegendOfZelda
{
    abstract class UpRedLinkState : RedLinkState
    {
        public UpRedLinkState(RedLink link) : base(link)
        {
            link.Direction = "up";
        }

        public override void Attack()
        {
            link.State = new AttackingUpRedLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillUpRedLinkState(link);
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileUpRedLinkState(link);
        }
    }
}
