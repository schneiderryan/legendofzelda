using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class Projectile : IProjectile
    {
        private Vector2 vel;
        private Vector2 pos;
        private ISprite sprite;

        public int X
        {
            get { return (int) pos.X; }
        }
        public int Y
        {
            get { return (int) pos.Y; }
        }

        public Projectile(ISprite sprite, Vector2 position,
                Vector2 velocity)
        {
            this.sprite = sprite;
            this.pos = position;
            this.vel = velocity;
        }

        public virtual void Update()
        {
            pos.X += vel.X;
            pos.Y += vel.Y;
            sprite.Position = new Point((int) pos.X, (int) pos.Y);
            sprite.Update();
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }
    }
}
