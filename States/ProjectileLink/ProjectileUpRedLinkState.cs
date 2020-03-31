

namespace LegendOfZelda
{
    class ProjectileUpRedLinkState : UpRedLinkState
    {
        public ProjectileUpRedLinkState(RedLink link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpProjectileLinkSprite();
        }

        public override void FireProjectile()
        {
            // nothing to do
        }
    }
}
