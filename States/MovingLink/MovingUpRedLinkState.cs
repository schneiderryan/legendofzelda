using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class MovingUpRedLinkState : UpRedLinkState
    {
        public MovingUpRedLinkState(RedLink link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpWalkingLinkSprite();
        }

        public override void MoveUp()
        {
            //Nothing to do
        }

        public override void Update()
        {
            link.Y -= 2;
            if (link.Y < 0)
            {
                link.Y += 480;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
