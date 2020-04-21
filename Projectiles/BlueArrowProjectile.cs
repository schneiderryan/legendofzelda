using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class BlueArrowProjectile : Projectile
    {
        public override double Damage => 2;

        public BlueArrowProjectile(string direction, int x, int y)
            : base(direction, x, y)
        {
            if(direction == "up")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateBlueUpArrow();
            } 
            else if(direction == "down")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateBlueDownArrow();
            } 
            else if(direction == "right")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateBlueRightArrow();
            } 
            else // left
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateBlueLeftArrow();
            }
            sprite.Position = new Point(X, Y);
            Hitbox = sprite.Box;
        }

        public override IDespawnEffect GetDespawnEffect()
        {
            return new DespawnEffect(Hitbox.Center);
        }

    }
}
