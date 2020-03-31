using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class AttackingRightLinkState : AttackingGreenLinkState
    {
        public AttackingRightLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "right";
        }

        public override void Attack()
        {
            this.link.UseProjectile(new SwordProjectile("right", this.link.X, this.link.Y));
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillRightLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateRightStillLinkSprite();
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }

    }
}
