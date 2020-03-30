

namespace LegendOfZelda
{
    class ProjectileDownRedLinkState : DownRedLinkState
    {
        public ProjectileDownRedLinkState(RedLink link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownProjectileLinkSprite();
        }

        public override void Projectile()
        {
            // nothing to do
        }
    }
}
