using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    abstract class Projectile : CollideableObject, IProjectile
    {
        public int VX { get; set; }
        public int VY { get; set; }
        public Team OwningTeam { get; set; }

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

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }

        public virtual IDespawnEffect GetDespawnEffect()
        {
            return new DespawnEffect(Hitbox.Center);
        }


        public static void CenterProjectile(Rectangle source,
                string direction, IProjectile projectile)
        {
            if (direction == "up")
            {
                projectile.X = source.Center.X - projectile.Hitbox.Width / 2;
                projectile.Y = source.Top - projectile.Hitbox.Height;
            }
            else if (direction == "down")
            {
                projectile.X = source.Center.X - projectile.Hitbox.Width / 2;
                projectile.Y = source.Bottom;
            }
            else if (direction == "right")
            {
                projectile.X = source.Right;
                projectile.Y = source.Center.Y - projectile.Hitbox.Height / 2;
            }
            else if (direction == "left")
            {
                projectile.X = source.Left - projectile.Hitbox.Width;
                projectile.Y = source.Center.Y - projectile.Hitbox.Height / 2;
            }
        }

    }
}
