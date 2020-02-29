using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class SwordDespawnEffect : IDespawnEffect
    {
        private ISprite upperLeft;
        private ISprite upperRight;
        private ISprite lowerLeft;
        private ISprite lowerRight;
        private const int SPREAD_RATE = 2;
        private const int INITIAL_LIFE = 18;
        private int life = INITIAL_LIFE;

        public bool Finished { get; private set; }

        public SwordDespawnEffect(Point position)
        {
            Finished = false;
            upperLeft = DespawnEffectSpriteFactory.SwordSpriteUpperLeft();
            upperRight = DespawnEffectSpriteFactory.SwordSpriteUpperRight();
            lowerLeft = DespawnEffectSpriteFactory.SwordSpriteLowerLeft();
            lowerRight = DespawnEffectSpriteFactory.SwordSpriteLowerRight();

            upperLeft.Position = position;
            upperRight.Position = position;
            lowerLeft.Position = position;
            lowerRight.Position = position;
        }

        public void Update()
        {
            life = (life - 1) % INITIAL_LIFE;
            Finished = life <= 0;

            upperLeft.Update();
            upperRight.Update();
            lowerLeft.Update();
            lowerRight.Update();

            upperLeft.X -= SPREAD_RATE;
            upperLeft.Y -= SPREAD_RATE;
            upperRight.X += SPREAD_RATE;
            upperRight.Y -= SPREAD_RATE;

            lowerLeft.X -= SPREAD_RATE;
            lowerLeft.Y += SPREAD_RATE;
            lowerRight.X += SPREAD_RATE;
            lowerRight.Y += SPREAD_RATE;
        }

        public void Draw(SpriteBatch sb)
        {
            upperLeft.Draw(sb);
            upperRight.Draw(sb);
            lowerLeft.Draw(sb);
            lowerRight.Draw(sb);
        }
    }
}
