﻿

namespace LegendOfZelda
{
    abstract class AttackingRedLinkState : RedLinkState
    {
        protected int attackTimer = 20;

        public AttackingRedLinkState(RedLink link)
            : base(link)
        {
            // nothing needed
        }
        public override void MoveUp() { }
        public override void MoveDown() { }
        public override void MoveRight() { }
        public override void MoveLeft() { }
        public override void BeStill() { }
        public override void FireProjectile() { }
    }
}
