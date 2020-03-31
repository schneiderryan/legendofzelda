using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    class SwordProjectile : Projectile
    {
        public override double Damage => 1;

        public SwordProjectile(string direction, int x, int y)
            : base(direction, x, y)
        {
            OwningTeam = Team.Link;
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
