using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class AttackingUpBlueLinkState : AttackingBlueLinkState
    {
        public AttackingUpBlueLinkState(IPlayer link) : base(link)
        {
            this.link.Direction = "up";
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueUpAttackingLinkSprite();
            // adjust for the presence of the sword in the sprite
            link.Sprite.Position = new Point(link.X, link.Y - 24);
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillUpBlueLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateBlueUpStillLinkSprite();
                base.Update();
            }
        }
    }
}
