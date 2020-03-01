using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    class SwordProjectile : Projectile
    {
        public SwordProjectile(string direction, Rectangle source)
            : base(direction, source.X, source.Y)
        {
            if (direction == "up")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateUpSwordProjectile();
                Hitbox = sprite.Box;
                X = source.Center.X - Hitbox.Width / 2;
                Y = source.Top - Hitbox.Height;
            }
            else if (direction == "down")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateDownSwordProjectile();
                Hitbox = sprite.Box;
                X = source.Center.X - Hitbox.Width / 2;
                Y = source.Bottom;
            }
            else if (direction == "right")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateRightSwordProjectile();
                Hitbox = sprite.Box;
                X = source.Right;
                Y = source.Center.Y - Hitbox.Height / 2;
            }
            else if (direction == "left")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateLeftSwordProjectile();
                Hitbox = sprite.Box;
                X = source.Left - Hitbox.Width;
                Y = source.Center.Y - Hitbox.Height / 2;
            }
        }

        public override IDespawnEffect GetDespawnEffect()
        {
            return new SwordDespawnEffect(Hitbox.Center);
        }
    }
}
