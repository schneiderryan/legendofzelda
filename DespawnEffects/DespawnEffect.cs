using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class DespawnEffect : IDespawnEffect
    {
        private ISprite sprite;
        private int timer;
        private const int DURATION = 4;

        public bool Finished { get; private set; }

        public DespawnEffect(Point position)
        {
            sprite = DespawnEffectSpriteFactory.GenericProjectileDespawn();
            sprite.Position = position;
            timer = -DURATION;
        }

        public void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }

        public void Update()
        {
            timer = (timer + 1) % DURATION;
            Finished = timer >= 0;
            sprite.Update();
        }

    }
}
