
namespace LegendOfZelda
{
    class RedLink : Link
    {
        public RedLink(LegendOfZelda game)
        {
            this.Sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
            this.Color = "red";
            this.State = new StillUpRedLinkState(this);
            this.Initialize(game);
        }
    }
}
