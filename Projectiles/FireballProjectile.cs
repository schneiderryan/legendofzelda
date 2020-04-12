using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class FireballProjectile : Projectile
    {
        public override double Damage => 0.5;

        public FireballProjectile(int x, int y, double vx, double vy)
            : base(x, y, vx, vy)
        {
            this.sprite = ProjectileSpriteFactory.Instance.CreateMovingFireballSprite();
            sprite.Position = new Point(X, Y);
            Hitbox = sprite.Box;
        }

        public override IDespawnEffect GetDespawnEffect()
        {
            return new DespawnEffect(new Point(X, Y));
        }
    }
}
