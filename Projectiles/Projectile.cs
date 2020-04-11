using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    abstract class Projectile : IProjectile
    {
        public double VX { get; set; }
        public double VY { get; set; }
        public Team OwningTeam { get; set; }
        public abstract double Damage { get; }

        public Rectangle Hitbox
        {
            get => hitbox;
            protected set => hitbox = value;
        }

        public int X
        {
            get => hitbox.X;
            set
            {
                x = value;
                hitbox.X = value;
            }
        }

        public int Y
        {
            get => hitbox.Y;
            set
            {
                y = value;
                hitbox.Y = value;
            }
        }

        protected ISprite sprite;
        private Rectangle hitbox;
        private double x;
        private double y;

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

        public Projectile(int x, int y, double vx, double vy, Team team = Team.Enemy)
        {
            OwningTeam = team;
            X = x;
            Y = y;
            VX = vx;
            VY = vy;
        }

        public virtual void Update()
        {
            x += VX;
            y += VY;
            hitbox.X = (int)x;
            hitbox.Y = (int)y;
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
