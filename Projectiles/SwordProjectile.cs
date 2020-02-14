
namespace LegendOfZelda
{
    class SwordProjectile : Projectile
    {
        public SwordProjectile(string direction, int xPos, int yPos)
            : base(direction, xPos, yPos)
        {
            if (direction == "up")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateUpSwordProjectile();
            }
            else if (direction == "down")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateDownSwordProjectile();
            }
            else if (direction == "right")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateRightSwordProjectile();
            }
            else if (direction == "left")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateLeftSwordProjectile();
            }
        }
    }
}
