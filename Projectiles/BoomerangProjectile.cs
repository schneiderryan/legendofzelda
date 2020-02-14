using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    public class BoomerangProjectile :  PlayerProjectile
    {
        public BoomerangProjectile(string direction, int xPos, int yPos)
            : base(direction, xPos, yPos)
        {
            this.sprite = ProjectileSpriteFactory.Instance.CreateBoomerang();
        }
    }
}
