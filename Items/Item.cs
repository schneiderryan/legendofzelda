using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public abstract class Item : IItem
    {
        protected ISprite sprite;
        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb, Color.White);
        }

        public virtual void Update()
        {
            sprite.Update();
        }

        public ISprite getSprite()
        {
            return this.sprite;
        }
    }
}
