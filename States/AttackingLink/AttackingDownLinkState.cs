using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class AttackingDownLinkState : AttackingGreenLinkState
    {
        public AttackingDownLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "down";
        }

        public override void Attack()
        {
            this.link.UseProjectile(new SwordProjectile("down", this.link.X, this.link.Y));
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillDownLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateDownStillLinkSprite();
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
