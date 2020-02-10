
namespace LegendOfZelda
{
    public class WoodSword : ProjectileItem
    {
        public WoodSword()
        {
            upSprite = ItemSpriteFactory.GetWoodSwordUp();
            rightSprite = ItemSpriteFactory.GetWoodSwordRight();
            State = ProjectileState.OnGround;
        }
    }
}
