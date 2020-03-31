

namespace LegendOfZelda
{
    class StillUpRedLinkState : UpRedLinkState
    {
        public StillUpRedLinkState(RedLink link) : base(link)
        {
            link.Sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
        }

        public override void BeStill()
        {
            //Nothing to do
        }
    }
}
