using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    class SwordProjectile : Projectile
    {
        public SwordProjectile(string direction, ICollideable source)
            : base(direction, source)
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
            sprite.Position = new Point(X, Y);
            Hitbox = sprite.Box;
        }

        public override IDespawnEffect GetDespawnEffect()
        {
            return new SwordDespawnEffect(Hitbox.Center);
        }
    }
}
