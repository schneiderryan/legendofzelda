using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    class MovingDownLinkState : ILinkState
    {
        private GreenLink link;

        public MovingDownLinkState(GreenLink link)
        {
            this.link = link;
            this.link.direction = "down";
        }

        public void MoveUp()
        {
            link.state = new MovingUpLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveDown()
        {
            //Nothing to do
        }

        public void MoveRight()
        {
            link.state = new MovingRightLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void MoveLeft()
        {
            link.state = new MovingLeftLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Attack()
        {
            link.state = new AttackingDownLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.state = new StillDownLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownStillLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public void Update()
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
