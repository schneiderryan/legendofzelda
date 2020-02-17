
namespace LegendOfZelda
{
    public class GreenLink : Link
    {
        public GreenLink(LegendOfZelda game)
        {
            this.sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            this.color = "green";
            this.state = new StillUpLinkState(this);
            this.Initialize(game);
        }
    }
}
