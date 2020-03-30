

namespace LegendOfZelda
{
    class ProjectileLeftRedLinkState : LeftRedLinkState
    {
        public ProjectileLeftRedLinkState(RedLink link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftProjectileLinkSprite();
        }

        public override void Projectile()
        {
            //Nothing to do
        }
    }
}
