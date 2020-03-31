using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class MovingDownLinkState : GreenLinkState
    {
        public MovingDownLinkState(GreenLink link)
        {
            this.link = link;
            this.link.Direction = "down";
        }

        public override void MoveUp()
        {
            link.State = new MovingUpLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpWalkingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void MoveDown()
        {
            //Nothing to do
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
            link.State = new AttackingDownLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownAttackingLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void BeStill()
        {
            link.State = new StillDownLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownStillLinkSprite();
            link.Sprite.Scale = 2.0f;
        }

        public override void PickupItem(IItem item, int time)
        {
            link.State = new GreenLinkPickupState(link, item, time);
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

        public override void FireProjectile()
        {
            link.State = new ProjectileDownLinkState(link);
            link.Sprite = PlayerSpriteFactory.Instance.CreateDownProjectileLinkSprite();
            link.Sprite.Scale = 2.0f;
        }
    }
}
