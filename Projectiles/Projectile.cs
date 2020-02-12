using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public abstract class Projectile : IProjectile
    {
        protected Vector2 velocity;
        protected Vector2 position;
        protected ISprite sprite;

        public Projectile(Vector2 position, Vector2 velocity)
        {
            this.position = position;
            this.velocity = velocity;
        }

        public virtual int X
        {
            get { return (int) position.X; }
        }
        public virtual int Y
        {
            get { return (int) position.Y; }
        }

        public virtual void Update()
        {
            position.X += velocity.X;
            position.Y += velocity.Y;
            sprite.Position = new Point((int) position.X, (int) position.Y);
            sprite.Update();
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb, Color.White);
        }
    }
}
