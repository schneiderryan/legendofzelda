
namespace LegendOfZelda
{
    public class GreenArrowProjectile : Projectile
    {
        public GreenArrowProjectile(string direction, int xPos, int yPos)
            : base(direction, xPos, yPos)
        {
            if (direction == "up")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateUpArrow();
            }
            else if (direction == "down")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateDownArrow();
            }
            else if (direction == "right")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateRightArrow();
            }
            else if (direction == "left")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateLeftArrow();
            }
        }
    }
}
