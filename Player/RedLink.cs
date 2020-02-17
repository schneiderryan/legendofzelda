
namespace LegendOfZelda
{
    public class RedLink : Link
    {
        public RedLink(LegendOfZelda game)
        {
            this.sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
            this.color = "red";
            this.state = new StillUpRedLinkState(this);
            this.Initialize(game);
        }
    }
}
