using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    abstract class LinkState : ILinkState
    {
        private int knockbackX = 0;
        private int knockbackY = 0;
        private int knockbackTimer = 0;
        private const int KNOCKBACK_TIME = 60;

        protected int VX { get; set; }
        protected int VY { get; set; }
        protected IPlayer link;

        public LinkState(IPlayer link)
        {
            this.link = link;
            VX = 0;
            VY = 0;
        }

        public abstract void Attack();
        public abstract void BeStill();
        public abstract void FireProjectile();
        public abstract void MoveDown();
        public abstract void MoveLeft();
        public abstract void MoveRight();
        public abstract void MoveUp();
        public abstract void PickupItem(IItem item, int time, bool twoHands = true);

        public virtual void Knockback(int xAmount, int yAmount)
        {
            knockbackX = xAmount / KNOCKBACK_TIME;
            knockbackY = yAmount / KNOCKBACK_TIME;
            knockbackTimer = KNOCKBACK_TIME;
        }

        public virtual void Update()
        {
            if (knockbackTimer > 0)
            {
                link.X += knockbackX;
                link.Y += knockbackY;
                knockbackTimer -= 1;
            }
            link.X += VX;
            link.Y += VY;
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
