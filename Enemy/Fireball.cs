using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    class Fireball : Enemy
    {
        public Fireball()
        {
            sprite = ProjectileSpriteFactory.GetMovingFireballSprite();
        }

        public override void Use(IEnemy aquamentus)
        {
            IProjectile fire = new FireballProjectile("",aquamentus.X, aquamentus.Y);
            aquamentus.UseProjectile(fire);
        }

        
    }
}
