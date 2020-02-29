using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    abstract class Projectile : CollideableObject, IProjectile
    {
        public int VX { get; protected set; }
        public int VY { get; protected set; }
        protected ISprite sprite;

        public Projectile(string direction, int xPos, int yPos,
            int initialVel = 8)
        {
            VX = 0;
            VY = 0;
            X = xPos;
            Y = yPos;

            if (direction == "up")
            {
                this.VY = -initialVel;
            }
            else if (direction == "down")
            {
                this.VY = initialVel;
            }
            else if (direction == "right")
            {
                this.VX = initialVel;
            }
            else if (direction == "left")
            {
                this.VX = -initialVel;
            }
        }

        public virtual void Update()
        {
            X += VX;
            Y += VY;
            sprite.Position = new Point(X, Y);
            sprite.Update();
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb, Color.White);
        }

        public virtual IDespawnEffect GetDespawnEffect() { return null; }
    }
}
