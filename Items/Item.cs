using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    abstract class Item : IItem
    {
        protected ISprite sprite;

        public int X
        {
            get { return sprite.Position.X; }
            set
            {
                sprite.Position = new Point(value, sprite.Position.Y);
            }
        }

        public int Y
        {
            get { return sprite.Position.Y; }
            set
            {
                sprite.Position = new Point(sprite.Position.X, value);
            }
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }

        public virtual void Update()
        {
            sprite.Update();
        }

        public abstract void Use(IPlayer player);
    }
}
