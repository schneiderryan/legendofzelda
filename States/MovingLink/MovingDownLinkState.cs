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
            link.sprite = PlayerSpriteFactory.Instance.CreateUpWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void MoveDown()
        {
            //Nothing to do
        }

        public void MoveRight()
        {
            link.state = new MovingRightLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateRightWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void MoveLeft()
        {
            link.state = new MovingLeftLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateLeftWalkingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void Attack()
        {
            link.state = new AttackingDownLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateDownAttackingLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void BeStill()
        {
            link.state = new StillDownLinkState(link);
            link.sprite = PlayerSpriteFactory.Instance.CreateDownStillLinkSprite();
            link.sprite.Scale = 2.0f;
        }

        public void Update()
        {
            link.Y += 2;
            if (link.Y > 480)
            {
                link.Y -= 480;
            }
            link.sprite.Position = new Point(link.X, link.Y);
        }

    }
}
