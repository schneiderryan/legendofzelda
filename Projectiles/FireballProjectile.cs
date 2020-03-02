using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class FireballProjectile :  Projectile
    {
        public FireballProjectile(string direction, ICollideable source, int initialVel = 2)
            : base(direction, source, initialVel)
        {
            this.sprite = ProjectileSpriteFactory.Instance.CreateMovingFireballSprite();
            sprite.Position = new Point(X, Y);
            Hitbox = sprite.Box;

            if (direction == "leftup")
            {
                this.VX = -8;
                this.VY = initialVel;
            }
            else if (direction == "leftdown")
            {
                this.VY = -initialVel;
                this.VX = -8;
            }
            else
            {
                this.VX = -8;
                this.VY = 0;
            }
        }
    }
}
