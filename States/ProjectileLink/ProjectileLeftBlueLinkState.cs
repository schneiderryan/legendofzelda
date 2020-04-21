

namespace LegendOfZelda
{
    class ProjectileLeftBlueLinkState : BlueLinkState
    {
        public ProjectileLeftBlueLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueLeftProjectileLinkSprite();
            link.Direction = "left";
        }

        public override void Attack()
        {
            link.State = new AttackingLeftBlueLinkState(link);
        }

        public override void BeStill()
        {
            link.State = new StillLeftBlueLinkState(link);
        }

        public override void FireProjectile()
        {
            //Nothing to do
        }
    }
}
