
namespace LegendOfZelda
{
    class GreenLink : Link
    {
        public GreenLink(LegendOfZelda game)
        {
            this.Sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            this.color = "green";
            this.state = new StillUpLinkState(this);
            this.Initialize(game);
        }
    }
}
