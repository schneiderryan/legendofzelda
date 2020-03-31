using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class AttackingUpLinkState : AttackingGreenLinkState
    {
        public AttackingUpLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "up";
        }

        public override void Attack()
        {
            this.link.UseProjectile(new SwordProjectile("up", this.link.X, this.link.Y));
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillUpLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }

    }
}
