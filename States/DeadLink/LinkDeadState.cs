using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    abstract class LinkDeadState : ILinkState
    {
        protected IPlayer link;
        protected const int FLASH_TIMER = 50;
        protected const int FLASH_DELAY = 10;
        protected const int SPIN_DELAY = 10;
        protected const int ROTATIONS = 3;
        protected const int DESPAWN_TIMER = 13;
        protected int flashTimer;
        protected int flashDelay;
        protected bool flashed;
        protected int spinDelay;
        protected int rotations;
        protected int despawnTimer;
        public LinkDeadState(IPlayer link)
        {
            this.link = link;
            flashTimer = FLASH_TIMER;
            flashDelay = FLASH_DELAY;
            spinDelay = SPIN_DELAY;
            rotations = ROTATIONS;
            despawnTimer = DESPAWN_TIMER;
            flashed = false;
            link.Direction = "down";
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

        public void PickupItem(IItem item, int time, bool twoHands = true)
        {
            // do nothing
        }

        public void Knockback(int amountX, int amountY)
        {
            // do nothing
        }
    }
}
