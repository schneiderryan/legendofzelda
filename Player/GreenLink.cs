
namespace LegendOfZelda
{
    class GreenLink : Link
    {
        public GreenLink(LegendOfZelda game)
        {
            this.Sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            this.Color = "green";
            this.State = new StillUpLinkState(this);
            this.Initialize(game);
        }
    }
}
