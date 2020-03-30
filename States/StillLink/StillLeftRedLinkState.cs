

namespace LegendOfZelda
{
    class StillLeftRedLinkState : LeftRedLinkState
    {
        public StillLeftRedLinkState(RedLink link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedLeftStillLinkSprite();
        }

        public override void BeStill()
        {
            //Nothing to do
        }
    }
}
