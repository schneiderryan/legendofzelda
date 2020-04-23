

namespace LegendOfZelda
{
    class AttackingDownBlueLinkState : AttackingBlueLinkState
    {
        public AttackingDownBlueLinkState(IPlayer link) : base(link)
        {
            this.link.Direction = "down";
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueDownAttackingLinkSprite();
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillDownBlueLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateBlueDownStillLinkSprite();
            }
            base.Update();
        }
    }
}
