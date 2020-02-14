
namespace LegendOfZelda
{
    class RedArrowProjectile : PlayerProjectile
    {
        public RedArrowProjectile(string direction, int xPos, int yPos)
            : base(direction, xPos, yPos)
        {
            if(direction == "up")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateRedUpArrow();
            } 
            else if(direction == "down")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateRedDownArrow();
            } 
            else if(direction == "right")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateRedRightArrow();
            } 
            else if(direction == "left")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateRedLeftArrow();
            }
        }
    }
}
