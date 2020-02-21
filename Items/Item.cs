using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    abstract class Item : IItem
    {
        protected ISprite sprite;
        private Rectangle hitbox;

        public Rectangle Hitbox
        {
            get { return hitbox; }
            protected set { hitbox = value; }
        }

        public int X
        {
            get { return hitbox.X; }
            set { hitbox.X = value; }
        }

        public int Y
        {
            get { return hitbox.Y; }
            set { hitbox.Y = value; }
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }

        public virtual void Update()
        {
            sprite.Position = new Point(X, Y);
            sprite.Update();
        }

        public abstract void Use(IPlayer player);
    }
}
