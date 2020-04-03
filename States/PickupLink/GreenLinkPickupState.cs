using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class GreenLinkPickupState : LinkPickupState
    {
        public GreenLinkPickupState(IPlayer link, IItem item, int time, bool twoHands = true)
            : base(link, item, time, twoHands)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateLinkPickup1();
            link.Sprite.Position = new Point(link.X, link.Y);
        }

        public override void Update()
        {
            if (delay > 20 && twoHands)
            {
                link.Sprite = PlayerSpriteFactory.Instance.CreateLinkPickup2();
            }
            if (delay == time)
            {
                link.State = new StillDownLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateDownStillLinkSprite();
                link.Sprite.Scale = 2.0f;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
            delay++;
            link.HeldItem.Update();
        }
    }
}
