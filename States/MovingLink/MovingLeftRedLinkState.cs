using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class MovingLeftRedLinkState : LeftRedLinkState
    {
        public MovingLeftRedLinkState(RedLink link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftWalkingLinkSprite();
        }

        public override void MoveLeft()
        {
            //Nothing to do
        }

        public override void Update()
        {
            link.X -= 2;
            if (link.X < 0)
            {
                link.X += 800;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
