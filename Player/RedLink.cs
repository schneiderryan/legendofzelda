
namespace LegendOfZelda
{
    class RedLink : Link
    {
        public RedLink(LegendOfZelda game)
        {
            this.Sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
            this.color = "red";
            this.state = new StillUpRedLinkState(this);
            this.Initialize(game);
        }
    }
}
