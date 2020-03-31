

namespace LegendOfZelda
{
    class ProjectileRightRedLinkState : RightRedLinkState
    {
        public ProjectileRightRedLinkState(RedLink link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedRightProjectileLinkSprite();
        }

        public override void FireProjectile()
        {
            //Nothing to do
        }
    }
}
