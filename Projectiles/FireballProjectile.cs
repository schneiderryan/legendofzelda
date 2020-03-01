
namespace LegendOfZelda
{
    class FireballProjectile :  Projectile
    {
        public FireballProjectile(string direction, int xPos, int yPos, int initialVel = 2)
            : base(direction, xPos, yPos)
        {
            this.sprite = ProjectileSpriteFactory.Instance.CreateMovingFireballSprite();

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
