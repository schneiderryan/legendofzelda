using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    public class Boomerang : ProjectileItem
    {
        public Boomerang()
        {
            rightSprite = ItemSpriteFactory.GetBoomerang();
            upSprite = ItemSpriteFactory.GetBoomerang();
            sprite = upSprite;
            State = ProjectileState.OnGround;
            initialVelocity = 4f;
        }
    }
}
