

namespace LegendOfZelda
{
    class AttackingLeftLinkState : AttackingGreenLinkState
    {
        public AttackingLeftLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateLeftAttackingLinkSprite();
            this.link.Direction = "left";
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillLeftLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateLeftStillLinkSprite();
            }
            base.Update();
        }
    }
}
