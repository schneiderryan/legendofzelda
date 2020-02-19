using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    public class FireballProjectile :  Projectile
    {
        public FireballProjectile(string direction, int xPos, int yPos, int initialVel = 2)
            : base(direction, xPos, yPos)
        {
            this.sprite = ProjectileSpriteFactory.Instance.CreateMovingFireballSprite();

            if (direction == "leftup")
            {
                this.xVel = -8;
                this.yVel = initialVel;
            }
            else if (direction == "leftdown")
            {
                this.yVel = -initialVel;
                this.xVel = -8;
                
            }
            else
            {
                this.xVel = -8;
                this.yVel = 0;
            }



        }
    }
}
