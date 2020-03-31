using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    internal class ProjectileDownLinkState : GreenLinkState
    {
        

        public ProjectileDownLinkState(GreenLink link)
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

        public override void Update()
        {
            link.Sprite.Position = new Point(link.X, link.Y);
        }

        public override void FireProjectile()
        {
            // Nothing to do
        }
    }
}
