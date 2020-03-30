using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class MovingRightRedLinkState : RightRedLinkState
    {
        public MovingRightRedLinkState(RedLink link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedRightWalkingLinkSprite();
        }

        public override void MoveRight()
        {
            //Nothing to do
        }

        public override void Update()
        {
            link.X += 2;
            if (link.X > 800)
            {
                link.X -= 800;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
        }
    }
}
