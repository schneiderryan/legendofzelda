using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class MovingRightLinkState : GreenLinkState
    {
        public MovingRightLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "right";
        }

        public override void MoveUp()
        {
            link.State = new MovingUpLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void MoveDown()
        {
            link.State = new MovingDownLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void MoveRight()
        {
            //Nothing to do
        }

        public override void MoveLeft()
        {
            link.State = new MovingLeftLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void Attack()
        {
            link.State = new AttackingRightLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void BeStill()
        {
            link.State = new StillRightLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightStillLinkSprite();
            link.Sprite.Scale = 2.0f;
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

        public override void FireProjectile()
        {
            link.State = new ProjectileRightLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateRightProjectileLinkSprite();
            link.Sprite.Scale = 2.0f;
        }
    }
}
