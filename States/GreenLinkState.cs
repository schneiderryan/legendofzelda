﻿

namespace LegendOfZelda
{
    abstract class GreenLinkState : ILinkState
    {
        protected GreenLink link;
        public abstract void Attack();
        public abstract void BeStill();
        public abstract void FireProjectile();
        public abstract void MoveDown();
        public abstract void MoveLeft();
        public abstract void MoveRight();
        public abstract void MoveUp();

        public virtual void PickupItem(IItem item, int time)
        {
            link.State = new GreenLinkPickupState(link, item, time);
        }

        public abstract void Update();
    }
}
