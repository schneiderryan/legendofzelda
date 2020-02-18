using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    class BoomerangProjectile :  Projectile
    {
        public BoomerangProjectile(string direction, int xPos, int yPos)
            : base(direction, xPos, yPos)
        {
            this.sprite = ProjectileSpriteFactory.Instance.CreateBoomerang();
        }
    }
}
