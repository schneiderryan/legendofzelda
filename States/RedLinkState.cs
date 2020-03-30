using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    abstract class RedLinkState : ILinkState
    {
        protected RedLink link;

        public RedLinkState(RedLink link)
        {
            this.link = link;
        }

        public abstract void Attack();
        public abstract void BeStill();
        public abstract void Projectile();

        public virtual void MoveDown()
        {
            link.State = new MovingDownRedLinkState(link);
        }

        public virtual void MoveLeft()
        {
            link.State = new MovingLeftRedLinkState(link);
        }

        public virtual void MoveRight()
        {
            link.State = new MovingRightRedLinkState(link);
        }

        public virtual void MoveUp()
        {
            link.State = new MovingUpRedLinkState(link);
        }


        public virtual void Update()
        {
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
