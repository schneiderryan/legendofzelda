using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class AttackingLeftRedLinkState : AttackingRedLinkState
    {
        public AttackingLeftRedLinkState(RedLink link) : base(link)
        {
            this.link.Direction = "left";
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftAttackingLinkSprite();
            // adjust for the presence of the sword in the sprite
            link.Sprite.Position = new Point(link.X - 24, link.Y);
        }

        public override void Attack()
        {
            this.link.UseProjectile(new SwordProjectile("left", this.link.X, this.link.Y));
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillLeftRedLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftStillLinkSprite();
                link.Sprite.Position = new Point(link.X, link.Y);
            }
        }
    }
}
