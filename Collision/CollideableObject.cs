using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    abstract class CollideableObject : ICollideable
    {
        private Rectangle hitbox = new Rectangle(0, 0, 32, 32);

        public virtual Rectangle Hitbox
        {
            get { return hitbox; }
            protected set { hitbox = value; }
        }

        // X & Y properties so that hitbox X & Y can be modified ez
        public virtual int X
        {
            get { return hitbox.X; }
            set { hitbox.X = value; }
        }

        public virtual int Y
        {
            get { return hitbox.Y; }
            set { hitbox.Y = value; }
        }
    }
}
