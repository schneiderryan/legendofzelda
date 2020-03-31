

namespace LegendOfZelda
{
    abstract class AttackingGreenLinkState : GreenLinkState
    {
        protected int attackTimer = 20;
        public override void MoveUp() { }
        public override void MoveDown() { }
        public override void MoveRight() { }
        public override void MoveLeft() { }
        public override void BeStill() { }
        public override void FireProjectile() { }
    }
}
