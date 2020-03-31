

namespace LegendOfZelda
{
    class StillRightRedLinkState : RightRedLinkState
    {
        public StillRightRedLinkState(RedLink link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedRightStillLinkSprite();
        }

        public override void BeStill()
        {
            //Nothing to do
        }
    }
}
