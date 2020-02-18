
namespace LegendOfZelda
{
    public class SwordProjectile : Projectile
    {

        public SwordProjectile(string direction, int xPos, int yPos)
            : base(direction, xPos, yPos)
        {
            
            if (direction == "up")
            {
                base.X += 5;
                base.Y -= 2;
                this.sprite = ProjectileSpriteFactory.Instance.CreateUpSwordProjectile();
            }
            else if (direction == "down")
            {
                base.Y += 15;
                base.X += 5;
                this.sprite = ProjectileSpriteFactory.Instance.CreateDownSwordProjectile();
            }
            else if (direction == "right")
            {
                base.X += 10;
                base.Y += 5;
                this.sprite = ProjectileSpriteFactory.Instance.CreateRightSwordProjectile();
            }
            else if (direction == "left")
            {
                base.Y += 5;
                this.sprite = ProjectileSpriteFactory.Instance.CreateLeftSwordProjectile();
            }
        }
    }
}
