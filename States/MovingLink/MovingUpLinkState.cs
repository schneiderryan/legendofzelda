using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class MovingUpLinkState : GreenLinkState
    {
        public MovingUpLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "up";
        }

        public override void MoveUp()
        {
            //Nothing to do
        }

        public override void MoveDown()
        {
            link.State = new MovingDownLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void MoveRight()
        {
            link.State = new MovingRightLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void MoveLeft()
        {
            link.State = new MovingLeftLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void Attack()
        {
            link.State = new AttackingUpLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void BeStill()
        {
            link.State = new StillUpLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            link.Sprite.Scale = 2.0f;
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

        public override void FireProjectile()
        {
            link.State = new ProjectileUpLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpProjectileLinkSprite();
            link.Sprite.Scale = 2.0f;
        }
    }
}
