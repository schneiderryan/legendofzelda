using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class AttackingLeftBlueLinkState : AttackingBlueLinkState
    {
        public AttackingLeftBlueLinkState(IPlayer link) : base(link)
        {
            this.link.Direction = "left";
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueLeftAttackingLinkSprite();
            // adjust for the presence of the sword in the sprite
            link.Sprite.Position = new Point(link.X - 24, link.Y);
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillLeftBlueLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateBlueLeftStillLinkSprite();
                base.Update();
            }
        }
    }
}
