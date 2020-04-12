

namespace LegendOfZelda
{
    class AttackingUpLinkState : AttackingGreenLinkState
    {
        public AttackingUpLinkState(IPlayer link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateUpAttackingLinkSprite();
            this.link.Direction = "up";
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillUpLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            }
            base.Update();
        }

    }
}
