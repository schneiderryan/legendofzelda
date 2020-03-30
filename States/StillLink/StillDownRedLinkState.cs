

namespace LegendOfZelda
{
    class StillDownRedLinkState : DownRedLinkState
    {
        public StillDownRedLinkState(RedLink link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedDownStillLinkSprite();
        }

        public override void BeStill()
        {
            // do nothing
        }
    }
}
