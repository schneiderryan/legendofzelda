
namespace LegendOfZelda
{
    public class WoodSword : Sword
    {
        public WoodSword()
        {
            upSprite = ItemSpriteFactory.GetWoodSwordUp();
            rightSprite = ItemSpriteFactory.GetWoodSwordRight();
            State = SwordState.OnGround;
        }
    }
}
