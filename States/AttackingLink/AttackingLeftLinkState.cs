using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class AttackingLeftLinkState : AttackingGreenLinkState
    {
        public AttackingLeftLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "left";
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
                link.State = new StillLeftLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateLeftStillLinkSprite();
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
