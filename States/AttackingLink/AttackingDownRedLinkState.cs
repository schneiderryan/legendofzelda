

namespace LegendOfZelda
{
    class AttackingDownRedLinkState : AttackingRedLinkState
    {
        public AttackingDownRedLinkState(IPlayer link) : base(link)
        {
            this.link.Direction = "down";
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownAttackingLinkSprite();
        }

        public override void Update()
        {
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            else
            {
                link.State = new StillDownRedLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownStillLinkSprite();
            }
            base.Update();
        }
    }
}
