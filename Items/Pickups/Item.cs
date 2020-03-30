using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    abstract class Item : CollideableObject, IItem
    {
        protected ISprite sprite;

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }

        public virtual void Update()
        {
            sprite.Position = new Point(X, Y);
            sprite.Update();
        }

        public abstract void Pickup(IPlayer player);
    }
}
