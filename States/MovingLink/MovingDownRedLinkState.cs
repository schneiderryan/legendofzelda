using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class MovingDownRedLinkState : DownRedLinkState
    {
        public MovingDownRedLinkState(RedLink link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownWalkingLinkSprite();
        }

        public override void MoveDown()
        {
            //Nothing to do
        }

        public override void Update()
        {
            link.Y += 2;
            if (link.Y > 480)
            {
                link.Y -= 480;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }

    }
}
