using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public abstract class Projectile : IProjectile
    {
        protected int xVel = 0;
        protected int yVel = 0;
        protected int initialVel = 10;
        protected ISprite sprite;

        public Projectile(string direction, int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
            sprite.Position = new Point(xPos, yPos);

            if (direction == "up")
            {
                this.yVel = -initialVel;
            }
            else if (direction == "down")
            {
                this.yVel = initialVel;
            }
            else if (direction == "right")
            {
                this.xVel = initialVel;
            }
            else if (direction == "left")
            {
                this.xVel = -initialVel;
            }
        }

        public virtual int X { get; protected set; }
        public virtual int Y { get; protected set; }

        public virtual void Update()
        {
            X += xVel;
            Y += yVel;
            sprite.Position = new Point(X, Y);
            sprite.Update();
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb, Color.White);
        }
    }
}
