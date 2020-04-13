

namespace LegendOfZelda
{
    class Explosion : Projectile
    {
        public override double Damage => 4;

        public bool Done => (sprite as AnimateOnceSprite).AnimationEnded;

        public Explosion(int x = 0, int y = 0)
            : base(x, y, 0, 0, Team.Link)
        {
            sprite = DespawnEffectSpriteFactory.GetExplodingBomb();
            Hitbox = sprite.Box;
            X = x;
            Y = y;
        }
    }
}
