﻿

namespace LegendOfZelda
{
    abstract class LinkPickupState : ILinkState
    {
        protected int delay;
        protected int time;

        public LinkPickupState(IPlayer link, IItem item, int time)
        {
            delay = 0;
            this.time = time;
            Util.CenterRelativeToEdge(link.Sprite.Box, "up", item);
            item.Update();
            link.HeldItem = item;
        }

        public abstract void Update();

        public void MoveUp()
        {
            //Nothing to do
        }

        public void MoveDown()
        {
            //Nothing to do
        }

        public void MoveRight()
        {
            //Nothing to do
        }

        public void MoveLeft()
        {
            //Nothing to do
        }

        public void Attack()
        {
            //Nothing to do
        }

        public void BeStill()
        {
            //Nothing to do
        }

        public void FireProjectile()
        {
            //Nothing to do
        }

        public void PickupItem(IItem item, int time)
        {
            // do nothing
        }
    }
}