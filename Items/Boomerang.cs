using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    public class Boomerang : ProjectileItem
    {
        public Boomerang()
        {
            rightSprite = ItemSpriteFactory.GetBoomerang();
            upSprite = ItemSpriteFactory.GetBoomerang();
            State = ProjectileState.OnGround;
            initialVelocity = 4f;
        }

        public override void ThrowLeft(Vector2 position)
        {
            base.ThrowLeft(position);
        }
    }
}
