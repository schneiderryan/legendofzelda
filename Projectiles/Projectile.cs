using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class Projectile : IProjectile
    {
        private Vector2 vel;
        private Vector2 pos;
        private ISprite sprite;

        public Vector2 Acceleration { get; set; }

        public Projectile(ISprite sprite, Vector2 position,
                Vector2 velocity, Vector2 acceleration = new Vector2())
        {
            this.sprite = sprite;
            this.pos = position;
            this.vel = velocity;
            this.Acceleration = acceleration;
        }

        public virtual void Update()
        {
            vel.X += Acceleration.X;
            vel.Y += Acceleration.Y;
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
