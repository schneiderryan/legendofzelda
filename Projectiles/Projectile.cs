using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class Projectile : IProjectile
    {
       public int VX { get; set; }
        public int VY { get; set; }
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

        public virtual int X { get; protected set; }
        public virtual int Y { get; protected set; }

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
    }
}
