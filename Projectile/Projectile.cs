using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class Projectile : IProjectile
    {
        protected Vector2 vel;
        protected Vector2 pos;
        protected ISprite sprite;
        

        public Projectile(ISprite sprite, Vector2 position,
                Vector2 velocity)
        {
            
            this.sprite = sprite;
            this.pos = position;
            this.vel = velocity;
        }

        public virtual void Update()
        {
            
                pos.X -= vel.X;
                pos.Y -= vel.Y;
           
            
            sprite.Position = new Point((int)pos.X, (int)pos.Y);
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }
    }
}