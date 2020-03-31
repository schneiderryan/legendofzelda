using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class RedLinkPickupState : LinkPickupState
    {
        private RedLink link;
        public RedLinkPickupState(RedLink link, IItem item, int time)
            : base(link, item, time)
        {
            this.link = link;
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLinkPickup1();
            link.Sprite.Position = new Point(link.X, link.Y);
        }

        public override void Update()
        {
            if (delay > 20)
            {
                link.Sprite = PlayerSpriteFactory.Instance.CreateRedLinkPickup2();
            }
            if (delay == time)
            {
                link.State = new StillDownRedLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownStillLinkSprite();
                link.Sprite.Scale = 2.0f;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
            delay++;
            link.HeldItem.Update();
        }
    }
}
