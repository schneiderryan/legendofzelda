using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    abstract class DespawnEffect : IDespawnEffect
    {
        protected ISprite sprite;

        public bool Finished { get; private set; }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }

        public virtual void Update()
        {
            sprite.Update();
        }
    }
}
