using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class BlueLinkPickupState : LinkPickupState
    {
        public BlueLinkPickupState(IPlayer link, IItem item, int time, bool twoHands = true)
            : base(link, item, time, twoHands)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueLinkPickup1();
            link.Sprite.Position = new Point(link.X, link.Y);
        }

        public override void Update()
        {
            if (delay > 20 && twoHands)
            {
                link.Sprite = PlayerSpriteFactory.Instance.CreateBlueLinkPickup2();
            }
            if (delay == time)
            {
                link.State = new StillDownBlueLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateBlueDownStillLinkSprite();
                link.Sprite.Scale = 2.0f;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
            delay++;
            link.HeldItem.Update();
        }
    }
}
