

namespace LegendOfZelda
{
    abstract class AttackingRedLinkState : RedLinkState
    {
        protected int attackTimer = 20;

        public AttackingRedLinkState(IPlayer link) : base(link)
        {
            VX = 0;
            VY = 0;
        }
        public override void MoveUp() { }
        public override void MoveDown() { }
        public override void MoveRight() { }
        public override void MoveLeft() { }
        public override void BeStill() { }
        public override void FireProjectile() { }
        public override void Attack() { }
    }
}
