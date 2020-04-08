

namespace LegendOfZelda
{
    abstract class LinkPickupState : ILinkState
    {
        protected int delay;
        protected int time;
        protected bool twoHands;
        protected IPlayer link;

        public LinkPickupState(IPlayer link, IItem item, int time, bool twoHands = true)
        {
            this.link = link;
            delay = 0;
            this.time = time;
            this.twoHands = twoHands;
            if (twoHands)
            {
                Util.CenterRelativeToEdge(link.Sprite.Box, "up", item);
            }
            else
            {
                item.X = link.X;
                item.Y = link.Y - item.Hitbox.Height;
            }
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