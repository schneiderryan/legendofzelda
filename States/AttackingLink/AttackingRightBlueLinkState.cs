

namespace LegendOfZelda
{
    class AttackingRightBlueLinkState : AttackingBlueLinkState
    {
        public AttackingRightBlueLinkState(IPlayer link) : base(link)
        {
            this.link.Direction = "right";
            link.Sprite = PlayerSpriteFactory.Instance.CreateBlueRightAttackingLinkSprite();
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillRightBlueLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateBlueRightStillLinkSprite();
            }
            base.Update();
        }

    }
}
