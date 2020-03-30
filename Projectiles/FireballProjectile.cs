using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class FireballProjectile :  Projectile
    {
        public override double Damage => 0.5;

        public FireballProjectile(string direction, int x, int y, int initialVel = 2)
            : base(direction, x, y, initialVel)
        {
            this.sprite = ProjectileSpriteFactory.Instance.CreateMovingFireballSprite();
            sprite.Position = new Point(X, Y);
            Hitbox = sprite.Box;

            if (direction.Equals("leftup"))
            {
                this.VX = -2;
                this.VY = -2;
            }
            else if (direction.Equals("leftdown"))
            {
                this.VY = 2;
                this.VX = -2;
            }
            else if(direction.Equals("rightdown"))
            {
                this.VX = 2;
                this.VY = 2;
            }
            else
            {
                this.VX = 0;
                this.VY = 2;
            }
        }
    }
}
