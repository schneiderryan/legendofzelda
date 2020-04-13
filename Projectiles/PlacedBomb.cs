using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class PlacedBomb : Projectile
    {
        public bool Exploded => timer <= -10;
        int timer;
        IProjectileManager projectiles;
        IProjectile center;
        IProjectile lowerRight;
        IProjectile midRight;
        IProjectile topLeft;

        public PlacedBomb(IProjectileManager projectiles, int x = 0, int y = 0)
            : base(x, y, 0, 0, Team.Link)
        {
            sprite = ItemSpriteFactory.GetBomb();
            X = x;
            Y = y;
            timer = 60;
            this.projectiles = projectiles;
            Hitbox = new Rectangle(X, Y, 0, 0);
        }

        public override double Damage => 0;

        public override void Update()
        {
            base.Update();
            timer--;
            if (timer == 0)
            {
                center = new Explosion(X, Y);
                projectiles.Add(center);
                lowerRight = new Explosion(X + center.Hitbox.Width / 2, Y + center.Hitbox.Height / 2);
                projectiles.Add(lowerRight);
                midRight = new Explosion(X + center.Hitbox.Width, Y);
                projectiles.Add(midRight);
                topLeft = new Explosion(X - center.Hitbox.Width / 2, Y - center.Hitbox.Height / 2);
                projectiles.Add(topLeft);
            }
            else if (timer == -10)
            {
                lowerRight.X -= center.Hitbox.Width;
                midRight.X -= 2 * center.Hitbox.Width;
                topLeft.X += center.Hitbox.Width;
            }
        }
    }
}
