using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    abstract class Projectile : CollideableObject, IProjectile
    {
        public int VX { get; set; }
        public int VY { get; set; }
        public Team OwningTeam { get; set; }
        public abstract double Damage { get; }

        protected ISprite sprite;

        public Projectile(string direction, int x, int y,
                int initialVel = 8, Team team = Team.Enemy)
        {
            OwningTeam = team;
            VX = 0;
            VY = 0;
            X = x;
            Y = y;

            if (direction == "up")
            {
                this.VY = -initialVel;
            }
            else if (direction == "down")
            {
                this.VY = initialVel;
            }
            else if (direction == "downleft")
            {
                this.VY = initialVel;
                this.VX = -initialVel;
            }
            else if (direction == "right")
            {
                this.VX = initialVel;
            }
            else if (direction == "downright")
            {
                this.VY = initialVel;
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

        public virtual void Draw(SpriteBatch sb, Color color)
        {
            sprite.Draw(sb, color);
        }

        public virtual IDespawnEffect GetDespawnEffect()
        {
            return new NoDespawnEffect();
        }
    }
}
