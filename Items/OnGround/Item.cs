using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    abstract class Item : CollideableObject, IItem
    {
        protected ISprite sprite;

        public virtual void Draw(SpriteBatch sb, Color color)
        {
            sprite.Draw(sb, color);
        }

        public virtual void Update()
        {
            sprite.Position = new Point(X, Y);
            sprite.Update();
        }

        public abstract void Collect(IPlayer player);
    }
}
