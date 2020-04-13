

namespace LegendOfZelda
{
    class StillLeftBlueLinkState : BlueLinkState
    {
        public StillLeftBlueLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueLeftStillLinkSprite();
            link.Direction = "left";
        }

        public override void Attack()
        {
            link.State = new AttackingLeftBlueLinkState(link);
        }

        public override void BeStill()
        {
            //Nothing to do
        }

        public override void FireProjectile()
        {
            link.State = new ProjectileLeftBlueLinkState(link);
        }
    }
}
